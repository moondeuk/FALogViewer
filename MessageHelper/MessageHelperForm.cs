using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FALogViewer.MessageHelper;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace FALogViewer
{
    public partial class MessageHelperForm : Form
    {
        private string messageHelpXmlFilePath;
        private MessageHelpInfoList messageHelpList;
        private bool isTextChanged = false;

        public MessageHelperForm(MessageHelpInfoList messageHelpList, string messageHelpXmlFilePath)
        {
            InitializeComponent();
            this.messageHelpList = messageHelpList;
            this.messageHelpList.IsChangeSaved = false;
            this.messageHelpXmlFilePath = messageHelpXmlFilePath;
        }

        private void MessageHelperForm_Load(object sender, EventArgs e)
        {
            this.ShowList();
        }

        private void lvMsgHelperList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMessageHelperList.SelectedItems.Count > 0)
            {
                int index = lvMessageHelperList.SelectedIndices[0];

                int stream = this.messageHelpList.Items[index].Stream;
                int function = this.messageHelpList.Items[index].Function;
                string description = this.messageHelpList.Items[index].Description;
                string messageHelp = this.messageHelpList.Items[index].MessageHelp;
                this.btnColorIndex.BackColor = Color.FromArgb(this.messageHelpList.Items[index].ColorIndex);
                
                this.txtStream.Text = Convert.ToString(stream);
                this.txtFunction.Text = Convert.ToString(function);
                this.txtDescription.Text = description;
                this.txtMessageHelp.Text = messageHelp;
                

                this.btnAdd.Text = "Modify";
                this.isTextChanged = false;
            }
        }

        private void ShowList()
        {
            lvMessageHelperList.BeginUpdate();
            lvMessageHelperList.Items.Clear();

            foreach (MessageHelpInfo messageHelp in this.messageHelpList.Items)
            {
                // *--- Column-00 Message Color
                ListViewItem item = new ListViewItem(string.Empty);
                item.SubItems[0].BackColor = Color.FromArgb(messageHelp.ColorIndex);
                item.UseItemStyleForSubItems = false;

                // *--- Column-01 Message ID
                item.SubItems.Add("S" + messageHelp.Stream + ", F" + messageHelp.Function);

                // *--- Column-02 Message Description
                item.SubItems.Add(messageHelp.Description);
                              
                lvMessageHelperList.Items.Add(item);
            }
            lvMessageHelperList.EndUpdate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtStream.Text != string.Empty && txtFunction.Text != string.Empty)
            {
                int inputStream;
                int inputFunction;

                if (int.TryParse(txtStream.Text, out inputStream) == false)
                {
                    MessageBox.Show("Stream is not number.");
                    return;
                }

                if (int.TryParse(txtFunction.Text, out inputFunction) == false)
                {
                    MessageBox.Show("Function is not number.");
                    return;
                }

                bool isModify = false;
                foreach (MessageHelpInfo messageHelp in this.messageHelpList.Items)
                {
                    // 같으면 수정만 한다.
                    if (messageHelp.Stream == inputStream && messageHelp.Function == inputFunction)
                    {
                        messageHelp.Stream = Convert.ToInt32(txtStream.Text);
                        messageHelp.Function = Convert.ToInt32(txtFunction.Text);
                        messageHelp.Description = this.txtDescription.Text;
                        messageHelp.MessageHelp = this.txtMessageHelp.Text;
                        messageHelp.ColorIndex = this.btnColorIndex.BackColor.ToArgb();

                        isModify = true;
                    }
                }

                if (isModify == false)
                {
                    MessageHelpInfo newMessageHelp = new MessageHelpInfo();
                    newMessageHelp.Stream = inputStream;
                    newMessageHelp.Function = inputFunction;
                    newMessageHelp.Description = this.txtDescription.Text;
                    newMessageHelp.MessageHelp = this.txtMessageHelp.Text;
                    newMessageHelp.ColorIndex = this.btnColorIndex.BackColor.ToArgb();
                    this.messageHelpList.Items.Add(newMessageHelp);
                }

                this.messageHelpList.Items.Sort(new MessageHelperComparer());

                this.ShowList();

                try
                {
                    XmlWriterSettings settings = new XmlWriterSettings();
                    settings.IndentChars = "\t";
                    settings.Indent = true;

                    using (StreamWriter sw = new StreamWriter(Application.StartupPath + "\\" + messageHelpXmlFilePath))
                    using (XmlWriter xw = XmlWriter.Create(sw, settings))
                    {
                        XmlSerializer xs = new XmlSerializer(typeof(MessageHelpInfoList));
                        xs.Serialize(xw, this.messageHelpList);
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Fail to save files");
                }
            }

            this.txtStream.Text = string.Empty;
            this.txtFunction.Text = string.Empty;
            this.txtDescription.Text = string.Empty;
            this.txtMessageHelp.Text = string.Empty;
            this.btnColorIndex.BackColor = Color.White;
            this.isTextChanged = false;

            this.messageHelpList.IsChangeSaved = true;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvMessageHelperList.SelectedItems.Count > 0)
            {
                int index = lvMessageHelperList.SelectedIndices[0];

                this.messageHelpList.Items.RemoveAt(index);
                this.ShowList();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.lvMessageHelperList.Items)
            {
                item.Selected = false;
            }

            this.txtStream.Text = string.Empty;
            this.txtFunction.Text = string.Empty;
            this.txtDescription.Text = string.Empty;
            this.txtMessageHelp.Text = string.Empty;
            this.btnColorIndex.BackColor = Color.White;

            this.btnAdd.Text = "Add";
            this.isTextChanged = false;
        }



        private void btnColorIndex_Click(object sender, EventArgs e)
        {
            colorDialog_ColorIndex.Color = btnColorIndex.BackColor;
            DialogResult dr = colorDialog_ColorIndex.ShowDialog();

            if (dr == DialogResult.OK)
            {
                btnColorIndex.BackColor = colorDialog_ColorIndex.Color;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.btnAdd.BackColor == Color.Yellow)
            {
                this.btnAdd.BackColor = Color.FromKnownColor(KnownColor.Control);
                this.btnAdd.UseVisualStyleBackColor = true;
            }
            else if (this.isTextChanged == true)
            {
                this.btnAdd.BackColor = Color.Yellow;
                this.btnAdd.UseVisualStyleBackColor = false;
            }
        }

        private void txtStream_TextChanged(object sender, EventArgs e)
        {
            this.isTextChanged = true;
        }

        private void txtFunction_TextChanged(object sender, EventArgs e)
        {
            this.isTextChanged = true;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            this.isTextChanged = true;
        }

        private void btnMessageColor_BackColorChanged(object sender, EventArgs e)
        {
            this.isTextChanged = true;
        }

        private void txtMessageHelp_TextChanged(object sender, EventArgs e)
        {
            this.isTextChanged = true;
        }
    }
}