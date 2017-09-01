using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Xml.Serialization;
using System.Xml;
using FALogViewer.MessageHelper;

namespace FALogViewer
{
    enum eMessageType
    {
        SECS_SEND,
        SECS_RCV,
        IF_ALARM,
        PROC_EVENT,
        PROC_ALARM,
        HSMS_STATE,
        HSMS_SEND,
        HSMS_RCV,
        UNKNOWN
    }

    enum eMsgTypeImg
    {
        ARROW_LEFT,
        ARROW_RIGHT,
        INFORMATION
    }

    enum eFilterImg
    {
        FILTER_NO,
        FILTER_YES
    }

    public partial class MainForm : Form
    {
        private int childFormNumber = 0;
        private List<SecsLog> secsLogs;
        private string fileName = string.Empty;

        Dictionary<int, int> msgIndexDic = new Dictionary<int, int>();

        private LogFileParsing logFileControl;
        MessageFilter messageFilter = new MessageFilter();
        MessageHelpInfoList messageHelpInfoList = new MessageHelpInfoList();
        MessageFind messageFind = new MessageFind();

        private readonly string messageHelpXmlFilePath = "MessageHelp.xml";

        // Delegates
        private delegate void DEL_LoadSecsMessages(BackgroundWorker worker, DoWorkEventArgs e);
        private delegate void DEL_ProgressRoutine(long totalValue, long currentValue, String currentStatus);
        private delegate void DEL_EnableControls(bool isEnable);
        
        public MainForm()
        {
            InitializeComponent();
            InitializeBackgroundWorker();

            // 기본적으로 FDC (S6, F1)은 제외되도록
            messageFilter.ExcludeMessages.Add("S6, F1");
            messageFilter.IsExcludeEnable = true;
            msgFilterButton.Image = imageListFilter.Images[(int)eFilterImg.FILTER_YES];

            try
            {
                using (StreamReader sr = new StreamReader(Application.StartupPath + "\\" + messageHelpXmlFilePath))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(MessageHelpInfoList));
                    this.messageHelpInfoList = (MessageHelpInfoList)xs.Deserialize(sr);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Coudn't open message helper file.");
            }
        }

        private void InitializeBackgroundWorker()
        {
            bwShowMessage.DoWork += new DoWorkEventHandler(bwShowMessage_DoWork);
            bwShowMessage.RunWorkerCompleted += new RunWorkerCompletedEventHandler(DoWorkComplete);
            bwLoadLogFile.DoWork += new DoWorkEventHandler(bwLoadLogFile_DoWork);
            bwLoadLogFile.RunWorkerCompleted += new RunWorkerCompletedEventHandler(DoWorkComplete);
        }

        private void DoWorkComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            this.EnableControls(true);
        }

        private void EnableControls(bool isEnable)
        {
            if (this.InvokeRequired)
            {
                DEL_EnableControls DEL_method = new DEL_EnableControls(EnableControls);
                this.Invoke(DEL_method, isEnable);
            }
            else
            {
                this.openToolStripButton.Enabled = isEnable;
                this.msgFilterButton.Enabled = isEnable;
                this.messageHelpButton.Enabled = isEnable;
                this.openToolStripMenuItem.Enabled = isEnable;
            }
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "창 " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "로그 파일 (*.log)|*.log|모든 파일 (*.*)|*.*";

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.fileName = openFileDialog.FileName;
                this.StartLoadLogFile();
            }
        }


        private void StartLoadLogFile()
        {
            this.logFileControl = new LogFileParsing(fileName);
            this.logFileControl.EV_updateProgress += new LogFileParsing.DEL_UpdateProgress(UpdateProgress);

            bwLoadLogFile.RunWorkerAsync();
        }

        private void LoadLogFile(BackgroundWorker worker, DoWorkEventArgs e)
        {
            List<string> messages = this.logFileControl.LoadWholeLogFile();

            secsLogs = logFileControl.RetrieveMessageList(messages);

            StartLoadMessages();
        }

        private void StartLoadMessages()
        {
            if (secsLogs == null) return;

            bwShowMessage.RunWorkerAsync();
        }

        private void ShowSecsMessagesToList(BackgroundWorker worker, DoWorkEventArgs e)
        {
            this.EnableControls(false);

            if (secsLogs == null) return;


            lvMsgMain.Items.Clear();
            lvMsgMain.BeginUpdate();

            int imgType;
            bool isIgnore = false;
            int msgIndex = 0;
            int listViewIndex = 0;
            string msgInfo;
            int colorIndex;

            msgIndexDic.Clear();

            string msgDesc = string.Empty;


            foreach (SecsLog secsLog in secsLogs)
            {

                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                if (this.messageFilter.IsExcludeEnable == true)
                {
                    foreach (string excludeMessage in this.messageFilter.ExcludeMessages)
                    {
                        if (secsLog.MessageID.Equals(excludeMessage))
                        {
                            isIgnore = true;
                            break;
                        }
                        else
                        {
                            isIgnore = false;
                        }
                    }
                }
                else if (this.messageFilter.IsIncludeEnable == true)
                {
                    foreach (string includeMessage in this.messageFilter.IncludeMessages)
                    {
                        if (secsLog.MessageID.Equals(includeMessage))
                        {
                            isIgnore = false;
                            break;
                        }
                        else
                        {
                            isIgnore = true;
                        }
                    }
                }
                else
                {
                    isIgnore = false;
                }

                switch (secsLog.MessageType)
                {
                    case eMessageType.SECS_SEND:
                        imgType = (int)eMsgTypeImg.ARROW_LEFT;
                        break;
                    case eMessageType.SECS_RCV:
                        imgType = (int)eMsgTypeImg.ARROW_RIGHT;
                        break;
                    default:
                        imgType = (int)eMsgTypeImg.INFORMATION;
                        break;
                }


                if (secsLog.SecsMessage != null)
                {
                    msgInfo = secsLog.SecsMessage.GetInfo();
                }
                else
                {
                    msgInfo = string.Empty;
                }


                MessageHelpInfo messageHelpInfo = messageHelpInfoList.GetMessageHelp(secsLog.MessageID);

                if (messageHelpInfo != null)
                {
                    msgDesc = messageHelpInfo.Description;
                    colorIndex = messageHelpInfo.ColorIndex;
                }
                else
                {
                    msgDesc = string.Empty;
                    colorIndex = Color.White.ToArgb();
                }


                if (isIgnore == false)
                {
                    // *--- Column-00 MsgType ICon
                    ListViewItem item = new ListViewItem(string.Empty, imgType);

                    // *--- Column-01 ColorIndex
                    item.SubItems.Add(string.Empty);
                    item.SubItems[1].BackColor = Color.FromArgb(colorIndex);
                    item.UseItemStyleForSubItems = false;

                    //*----  Column-02 Msg ID
                    item.SubItems.Add(secsLog.MessageID);

                    // *---- Column-03 TimeStamp
                    item.SubItems.Add(secsLog.TimeStamp);

                    // *--- Column-04 Message Information
                    item.SubItems.Add(msgInfo);

                    // *--- Column-05 Message Description
                    item.SubItems.Add(msgDesc);

                    // *--- Column-06 System Byte
                    item.SubItems.Add(secsLog.SystemByte);

                    lvMsgMain.Items.Add(item);
                    msgIndexDic.Add(listViewIndex, msgIndex);

                    listViewIndex++;
                }


                msgIndex++;

                this.UpdateProgress(secsLogs.Count, msgIndex, "Showing Messages");
            }
            this.UpdateProgress(100, 0, "Complete");
            lvMsgMain.EndUpdate();

        }

        private SecsLog GetSecsLog(int index)
        {
            if (index < secsLogs.Count)
                return secsLogs[index];
            else
                return null;
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }
        
        public void UpdateProgress(long totalValue, long currentValue, String currentStatus)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new DEL_ProgressRoutine(UpdateProgress),
                            new Object[] {totalValue, currentValue, currentStatus});
            }
            else
            {
                this.progressBarLoading.Maximum = 100;

                int percentComplete = (int)((float)currentValue / (float)totalValue * 100);
                this.progressBarLoading.Value = percentComplete;
                this.toolStripStatusLabel.Text = currentStatus;

                if (this.progressBarLoading.Value >= this.progressBarLoading.Maximum)
                {
                    this.progressBarLoading.Value = 0;
                }

                Application.DoEvents();
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }



        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lvMsgMain.Columns[0].Width = 25;
            lvMsgMain.Columns[1].Width = 25;
            lvMsgMain.Columns[2].Width = 80;
            lvMsgMain.Columns[3].Width = 80;
            lvMsgMain.Columns[4].Width = 200;
            lvMsgMain.Columns[5].Width = 150;
            lvMsgMain.Columns[6].Width = 100;
        }

        private void lvMsgMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMsgMain.SelectedItems.Count > 0)
            {
                int index = lvMsgMain.SelectedIndices[0];

                int msgIndex = this.msgIndexDic[index];

                SecsLog secsLog = this.GetSecsLog(msgIndex);

                long endFilePosition = secsLog.FilePosition + LogFileParsing.maxReadBuffer;

                SecsLog nextSecsLog = this.GetSecsLog(msgIndex + 1);

                if (nextSecsLog != null)
                {
                    endFilePosition = nextSecsLog.FilePosition;
                }

                List<string> messages = this.logFileControl.LoadLogFileByPosition(secsLog.FilePosition, endFilePosition);

                // *--- Message Type
                txtMessageType.Text = secsLog.MessageType.ToString();

                // *--- Message ID
                txtMessageID.Text = secsLog.MessageID;

                // *--- Message Body
                rtbWholeMsg.Text = string.Empty;

                StringBuilder sbMsgBody = new StringBuilder();

                int i = 1;
                foreach (string message in messages)
                {
                    sbMsgBody.Append(message.Substring(message.IndexOf(':') + 2));
                    
                    this.UpdateProgress(messages.Count, i++, "Showing Message Body");
                }

                rtbWholeMsg.AppendText(sbMsgBody.ToString());

                this.UpdateProgress(100, 0, "Complete");
                

                // *--- Information
                string information;

                if (secsLog.SecsMessage != null)
                {
                    information = secsLog.SecsMessage.GetInfo();
                }
                else
                {
                    information = string.Empty;
                }

                txtInformation.Text = information;

                // *--- Message Help
                MessageHelpInfo messageHelpInfo = messageHelpInfoList.GetMessageHelp(secsLog.MessageID);
                string messageHelp;
                string description = string.Empty;

                if (messageHelpInfo != null)
                {
                    messageHelp = messageHelpInfo.MessageHelp;
                    description = messageHelpInfo.Description;
                }
                else
                {
                    messageHelp = string.Empty;
                }

                rtbMessageHelper.Text = messageHelp;

                // *--- Description
                this.txtDescription.Text = description;
            }
        }



        private void msgFilterButton_Click(object sender, EventArgs e)
        {
            FilterForm filterForm = new FilterForm(this.messageFilter);
            DialogResult dr = filterForm.ShowDialog();

            if (dr == DialogResult.OK)
            {
                if (messageFilter.IsFiltered == true)
                {
                    msgFilterButton.Image = imageListFilter.Images[(int)eFilterImg.FILTER_YES];
                }
                else
                {
                    msgFilterButton.Image = imageListFilter.Images[(int)eFilterImg.FILTER_NO];
                }

                this.StartLoadMessages();
            }
        }


        private void bwShowMessage_DoWork(object sender, DoWorkEventArgs e)
        {
            this.EnableControls(false);
            BackgroundWorker worker = sender as BackgroundWorker;
            this.Invoke(new DEL_LoadSecsMessages(ShowSecsMessagesToList), worker, e);
        }

        private delegate void DEL_LoadLogFile(BackgroundWorker worker, DoWorkEventArgs e);

        private void bwLoadLogFile_DoWork(object sender, DoWorkEventArgs e)
        {
            this.EnableControls(false);
            BackgroundWorker worker = sender as BackgroundWorker;
            LoadLogFile(worker, e);
        }


        protected override void OnDragEnter(DragEventArgs drgevent)
        {
            base.OnDragEnter(drgevent);

            drgevent.Effect = DragDropEffects.Copy;
        }


        protected override void OnDragDrop(DragEventArgs drgevent)
        {
            base.OnDragDrop(drgevent);

            try
            {
                if (drgevent.Data.GetDataPresent(DataFormats.FileDrop, false))
                {
                    string[] fileNames = (string[])drgevent.Data.GetData(DataFormats.FileDrop);

                    foreach (string fileName in fileNames)
                    {
                        this.fileName = fileName;
                        this.StartLoadLogFile();
                        
                    }
                }
            }
            catch (System.Exception)
            {
            }
        }

        private void messageHelpButton_Click(object sender, EventArgs e)
        {
            MessageHelperForm filterForm = new MessageHelperForm(this.messageHelpInfoList, this.messageHelpXmlFilePath);
            DialogResult dr = filterForm.ShowDialog();
            if (dr == DialogResult.OK && this.messageHelpInfoList.IsChangeSaved == true)
            {
                this.StartLoadMessages();
            }
        }


        private void toolStripMenuItem_WholeMsgSelect_Click(object sender, EventArgs e)
        {
            if (rtbWholeMsg.Focused && rtbWholeMsg.SelectionLength > 0)
                rtbWholeMsg.SelectAll();
        }

        private void toolStripMenuItem_WholeMsgCopy_Click(object sender, EventArgs e)
        {
            if (rtbWholeMsg.Focused && rtbWholeMsg.SelectionLength > 0)
                rtbWholeMsg.Copy();
        }
 

        private void toolStripMenuItem_MsgHelperSelect_Click(object sender, EventArgs e)
        {
            if (rtbMessageHelper.Focused && rtbMessageHelper.SelectionLength > 0)
                rtbMessageHelper.SelectAll();
        }

        private void toolStripMenuItem_MsgHelperCopy_Click(object sender, EventArgs e)
        {
            if (rtbMessageHelper.Focused && rtbMessageHelper.SelectionLength > 0)
                rtbMessageHelper.Copy();
        }

        private void toolStripMenuItem_MsgListFind_Click(object sender, EventArgs e)
        {
            this.messageFind.FindText = string.Empty;
            this.messageFind.IsDownDirection = true;

            FindForm findForm = new FindForm(this.messageFind);
            DialogResult dr = findForm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.FindNextMessage();
            }
        }

        private void FindNextMessage()
        {
            int startIndex;
            int endIndex;
            int step;
            int selectedIndex;
            string itemText;

            List<int> indexList = new List<int>();

            if (this.messageFind.IsLookAt_ID)
            {
                indexList.Add(2);
            }
            if (this.messageFind.IsLookAt_DateTime)
            {
                indexList.Add(3);
            }
            if (this.messageFind.IsLookAt_Info)
            {
                indexList.Add(4);
            }
            if (this.messageFind.IsLookAt_Description)
            {
                indexList.Add(5);
            }
            if (this.messageFind.IsLookAt_SystemByte)
            {
                indexList.Add(6);
            }


            if (lvMsgMain.SelectedItems.Count > 0)
            {
                selectedIndex = lvMsgMain.SelectedIndices[0];
            }
            else
            {
                selectedIndex = -1;
                return;
            }

            if (this.messageFind.IsDownDirection == true)
            {
                endIndex = lvMsgMain.Items.Count - 1;
                step = 1;
            }
            else
            {
                endIndex = 0;
                step = -1;
            }

            startIndex = selectedIndex + step;

            if (startIndex >= lvMsgMain.Items.Count)
            {
                MessageBox.Show("Can't find matching text");
                return;
            }

            for (int i = startIndex; i != endIndex; i=i+step)
            {
                for (int j = 0; j < indexList.Count; j++)
                {
                    int index = indexList[j];
                    itemText = lvMsgMain.Items[i].SubItems[index].Text;
                    if (itemText.IndexOf(this.messageFind.FindText) >= 0)
                    {
                        lvMsgMain.Items[i].Selected = true;
                        lvMsgMain.Items[i].EnsureVisible();
                        return;
                    }
                }
            }

            MessageBox.Show("Can't find matching text");
        }

        private void toolStripMenuItem_MsgListNextFind_Click(object sender, EventArgs e)
        {
            this.FindNextMessage();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void goToTheOhterPairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedIndex;
            string systemByte;

            if (lvMsgMain.SelectedItems.Count > 0)
            {
                selectedIndex = lvMsgMain.SelectedIndices[0];
                systemByte = lvMsgMain.Items[selectedIndex].SubItems[6].Text;

                for (int i = 0; i < lvMsgMain.Items.Count; i++)
                {
                    if (i != selectedIndex && lvMsgMain.Items[i].SubItems[6].Text == systemByte)
                    {
                        lvMsgMain.Items[i].Selected = true;
                        lvMsgMain.Items[i].EnsureVisible();
                        return;
                    }
                }

                MessageBox.Show("Can't find the other pair");
            }
            else
            {
                return;
            }
        }
    }
}
