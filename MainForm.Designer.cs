using System.Windows.Forms;
namespace FALogViewer
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvMsgMain = new FALogViewer.MyListView();
            this.MessageIcon = new System.Windows.Forms.ColumnHeader();
            this.ColorIndex = new System.Windows.Forms.ColumnHeader();
            this.MessageID = new System.Windows.Forms.ColumnHeader();
            this.DateTime = new System.Windows.Forms.ColumnHeader();
            this.Info = new System.Windows.Forms.ColumnHeader();
            this.Description = new System.Windows.Forms.ColumnHeader();
            this.SystemByte = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip_MsgList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_MsgListFind = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_MsgListNextFind = new System.Windows.Forms.ToolStripMenuItem();
            this.goToTheOhterPairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListMsgType = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtMessageType = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtMessageID = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.rtbMessageHelper = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip_MsgHelper = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_MsgHelperSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_MsgHelperCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbWholeMsg = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip_WholeMsg = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_WholeMsgSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_WholeMsgCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.txtInformation = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.msgFilterButton = new System.Windows.Forms.ToolStripButton();
            this.messageHelpButton = new System.Windows.Forms.ToolStripButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBarLoading = new System.Windows.Forms.ToolStripProgressBar();
            this.imageListFilter = new System.Windows.Forms.ImageList(this.components);
            this.bwShowMessage = new System.ComponentModel.BackgroundWorker();
            this.bwLoadLogFile = new System.ComponentModel.BackgroundWorker();
            this.bwRetrieveMessage = new System.ComponentModel.BackgroundWorker();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip_MsgList.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.contextMenuStrip_MsgHelper.SuspendLayout();
            this.contextMenuStrip_WholeMsg.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvMsgMain);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            // 
            // lvMsgMain
            // 
            this.lvMsgMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MessageIcon,
            this.ColorIndex,
            this.MessageID,
            this.DateTime,
            this.Info,
            this.Description,
            this.SystemByte});
            this.lvMsgMain.ContextMenuStrip = this.contextMenuStrip_MsgList;
            resources.ApplyResources(this.lvMsgMain, "lvMsgMain");
            this.lvMsgMain.FullRowSelect = true;
            this.lvMsgMain.GridLines = true;
            this.lvMsgMain.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvMsgMain.HideSelection = false;
            this.lvMsgMain.LargeImageList = this.imageListMsgType;
            this.lvMsgMain.MultiSelect = false;
            this.lvMsgMain.Name = "lvMsgMain";
            this.lvMsgMain.SmallImageList = this.imageListMsgType;
            this.lvMsgMain.UseCompatibleStateImageBehavior = false;
            this.lvMsgMain.View = System.Windows.Forms.View.Details;
            this.lvMsgMain.SelectedIndexChanged += new System.EventHandler(this.lvMsgMain_SelectedIndexChanged);
            // 
            // MessageIcon
            // 
            resources.ApplyResources(this.MessageIcon, "MessageIcon");
            // 
            // ColorIndex
            // 
            resources.ApplyResources(this.ColorIndex, "ColorIndex");
            // 
            // MessageID
            // 
            resources.ApplyResources(this.MessageID, "MessageID");
            // 
            // DateTime
            // 
            resources.ApplyResources(this.DateTime, "DateTime");
            // 
            // Info
            // 
            resources.ApplyResources(this.Info, "Info");
            // 
            // Description
            // 
            resources.ApplyResources(this.Description, "Description");
            // 
            // SystemByte
            // 
            resources.ApplyResources(this.SystemByte, "SystemByte");
            // 
            // contextMenuStrip_MsgList
            // 
            this.contextMenuStrip_MsgList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_MsgListFind,
            this.toolStripMenuItem_MsgListNextFind,
            this.goToTheOhterPairToolStripMenuItem});
            this.contextMenuStrip_MsgList.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip_MsgList, "contextMenuStrip_MsgList");
            // 
            // toolStripMenuItem_MsgListFind
            // 
            this.toolStripMenuItem_MsgListFind.Name = "toolStripMenuItem_MsgListFind";
            resources.ApplyResources(this.toolStripMenuItem_MsgListFind, "toolStripMenuItem_MsgListFind");
            this.toolStripMenuItem_MsgListFind.Click += new System.EventHandler(this.toolStripMenuItem_MsgListFind_Click);
            // 
            // toolStripMenuItem_MsgListNextFind
            // 
            this.toolStripMenuItem_MsgListNextFind.Name = "toolStripMenuItem_MsgListNextFind";
            resources.ApplyResources(this.toolStripMenuItem_MsgListNextFind, "toolStripMenuItem_MsgListNextFind");
            this.toolStripMenuItem_MsgListNextFind.Click += new System.EventHandler(this.toolStripMenuItem_MsgListNextFind_Click);
            // 
            // goToTheOhterPairToolStripMenuItem
            // 
            this.goToTheOhterPairToolStripMenuItem.Name = "goToTheOhterPairToolStripMenuItem";
            resources.ApplyResources(this.goToTheOhterPairToolStripMenuItem, "goToTheOhterPairToolStripMenuItem");
            this.goToTheOhterPairToolStripMenuItem.Click += new System.EventHandler(this.goToTheOhterPairToolStripMenuItem_Click);
            // 
            // imageListMsgType
            // 
            this.imageListMsgType.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMsgType.ImageStream")));
            this.imageListMsgType.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMsgType.Images.SetKeyName(0, "arrow_left.PNG");
            this.imageListMsgType.Images.SetKeyName(1, "arrow_right.PNG");
            this.imageListMsgType.Images.SetKeyName(2, "Information.png");
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtInformation, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.txtMessageType, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtDescription, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtMessageID, 1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // txtMessageType
            // 
            this.txtMessageType.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtMessageType, "txtMessageType");
            this.txtMessageType.Name = "txtMessageType";
            this.txtMessageType.ReadOnly = true;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtDescription, "txtDescription");
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            // 
            // txtMessageID
            // 
            this.txtMessageID.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtMessageID, "txtMessageID");
            this.txtMessageID.Name = "txtMessageID";
            this.txtMessageID.ReadOnly = true;
            // 
            // splitContainer2
            // 
            resources.ApplyResources(this.splitContainer2, "splitContainer2");
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.rtbMessageHelper);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.rtbWholeMsg);
            // 
            // rtbMessageHelper
            // 
            this.rtbMessageHelper.ContextMenuStrip = this.contextMenuStrip_MsgHelper;
            resources.ApplyResources(this.rtbMessageHelper, "rtbMessageHelper");
            this.rtbMessageHelper.EnableAutoDragDrop = true;
            this.rtbMessageHelper.Name = "rtbMessageHelper";
            this.rtbMessageHelper.ReadOnly = true;
            // 
            // contextMenuStrip_MsgHelper
            // 
            this.contextMenuStrip_MsgHelper.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_MsgHelperSelect,
            this.toolStripMenuItem_MsgHelperCopy});
            this.contextMenuStrip_MsgHelper.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip_MsgHelper, "contextMenuStrip_MsgHelper");
            // 
            // toolStripMenuItem_MsgHelperSelect
            // 
            this.toolStripMenuItem_MsgHelperSelect.Name = "toolStripMenuItem_MsgHelperSelect";
            resources.ApplyResources(this.toolStripMenuItem_MsgHelperSelect, "toolStripMenuItem_MsgHelperSelect");
            this.toolStripMenuItem_MsgHelperSelect.Click += new System.EventHandler(this.toolStripMenuItem_MsgHelperSelect_Click);
            // 
            // toolStripMenuItem_MsgHelperCopy
            // 
            this.toolStripMenuItem_MsgHelperCopy.Name = "toolStripMenuItem_MsgHelperCopy";
            resources.ApplyResources(this.toolStripMenuItem_MsgHelperCopy, "toolStripMenuItem_MsgHelperCopy");
            this.toolStripMenuItem_MsgHelperCopy.Click += new System.EventHandler(this.toolStripMenuItem_MsgHelperCopy_Click);
            // 
            // rtbWholeMsg
            // 
            this.rtbWholeMsg.BackColor = System.Drawing.Color.White;
            this.rtbWholeMsg.ContextMenuStrip = this.contextMenuStrip_WholeMsg;
            resources.ApplyResources(this.rtbWholeMsg, "rtbWholeMsg");
            this.rtbWholeMsg.EnableAutoDragDrop = true;
            this.rtbWholeMsg.Name = "rtbWholeMsg";
            this.rtbWholeMsg.ReadOnly = true;
            // 
            // contextMenuStrip_WholeMsg
            // 
            this.contextMenuStrip_WholeMsg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_WholeMsgSelect,
            this.toolStripMenuItem_WholeMsgCopy});
            this.contextMenuStrip_WholeMsg.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip_WholeMsg, "contextMenuStrip_WholeMsg");
            // 
            // toolStripMenuItem_WholeMsgSelect
            // 
            this.toolStripMenuItem_WholeMsgSelect.Name = "toolStripMenuItem_WholeMsgSelect";
            resources.ApplyResources(this.toolStripMenuItem_WholeMsgSelect, "toolStripMenuItem_WholeMsgSelect");
            this.toolStripMenuItem_WholeMsgSelect.Click += new System.EventHandler(this.toolStripMenuItem_WholeMsgSelect_Click);
            // 
            // toolStripMenuItem_WholeMsgCopy
            // 
            this.toolStripMenuItem_WholeMsgCopy.Name = "toolStripMenuItem_WholeMsgCopy";
            resources.ApplyResources(this.toolStripMenuItem_WholeMsgCopy, "toolStripMenuItem_WholeMsgCopy");
            this.toolStripMenuItem_WholeMsgCopy.Click += new System.EventHandler(this.toolStripMenuItem_WholeMsgCopy_Click);
            // 
            // txtInformation
            // 
            this.txtInformation.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtInformation, "txtInformation");
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.ReadOnly = true;
            // 
            // menuStrip
            // 
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.viewMenu,
            this.toolsMenu,
            this.helpMenu});
            this.menuStrip.Name = "menuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            resources.ApplyResources(this.fileMenu, "fileMenu");
            this.fileMenu.Name = "fileMenu";
            // 
            // openToolStripMenuItem
            // 
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.viewMenu.Name = "viewMenu";
            resources.ApplyResources(this.viewMenu, "viewMenu");
            // 
            // toolBarToolStripMenuItem
            // 
            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckOnClick = true;
            this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            resources.ApplyResources(this.toolBarToolStripMenuItem, "toolBarToolStripMenuItem");
            this.toolBarToolStripMenuItem.Click += new System.EventHandler(this.ToolBarToolStripMenuItem_Click);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            resources.ApplyResources(this.statusBarToolStripMenuItem, "statusBarToolStripMenuItem");
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsMenu.Name = "toolsMenu";
            resources.ApplyResources(this.toolsMenu, "toolsMenu");
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            resources.ApplyResources(this.helpMenu, "helpMenu");
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            resources.ApplyResources(this.toolStrip, "toolStrip");
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.msgFilterButton,
            this.messageHelpButton});
            this.toolStrip.Name = "toolStrip";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.openToolStripButton, "openToolStripButton");
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Click += new System.EventHandler(this.OpenFile);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // msgFilterButton
            // 
            this.msgFilterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.msgFilterButton, "msgFilterButton");
            this.msgFilterButton.Name = "msgFilterButton";
            this.msgFilterButton.Click += new System.EventHandler(this.msgFilterButton_Click);
            // 
            // messageHelpButton
            // 
            this.messageHelpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.messageHelpButton, "messageHelpButton");
            this.messageHelpButton.Name = "messageHelpButton";
            this.messageHelpButton.Click += new System.EventHandler(this.messageHelpButton_Click);
            // 
            // statusStrip
            // 
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.progressBarLoading});
            this.statusStrip.Name = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            resources.ApplyResources(this.toolStripStatusLabel, "toolStripStatusLabel");
            // 
            // progressBarLoading
            // 
            this.progressBarLoading.Name = "progressBarLoading";
            resources.ApplyResources(this.progressBarLoading, "progressBarLoading");
            // 
            // imageListFilter
            // 
            this.imageListFilter.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListFilter.ImageStream")));
            this.imageListFilter.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListFilter.Images.SetKeyName(0, "filter_no.png");
            this.imageListFilter.Images.SetKeyName(1, "filter_yes.png");
            // 
            // bwShowMessage
            // 
            this.bwShowMessage.WorkerReportsProgress = true;
            this.bwShowMessage.WorkerSupportsCancellation = true;
            // 
            // bwLoadLogFile
            // 
            this.bwLoadLogFile.WorkerReportsProgress = true;
            this.bwLoadLogFile.WorkerSupportsCancellation = true;
            // 
            // bwRetrieveMessage
            // 
            this.bwRetrieveMessage.WorkerReportsProgress = true;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip_MsgList.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.contextMenuStrip_MsgHelper.ResumeLayout(false);
            this.contextMenuStrip_WholeMsg.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MyListView lvMsgMain;
        private System.Windows.Forms.ColumnHeader MessageID;
        private System.Windows.Forms.ColumnHeader DateTime;
        private System.Windows.Forms.ImageList imageListMsgType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtMessageType;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ToolStripButton msgFilterButton;
        private System.Windows.Forms.ImageList imageListFilter;
        private System.ComponentModel.BackgroundWorker bwShowMessage;
        private System.ComponentModel.BackgroundWorker bwLoadLogFile;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.ComponentModel.BackgroundWorker bwRetrieveMessage;
        private ContextMenuStrip contextMenuStrip_WholeMsg;
        private ToolStripMenuItem toolStripMenuItem_WholeMsgSelect;
        private ToolStripMenuItem toolStripMenuItem_WholeMsgCopy;
        private RichTextBox rtbWholeMsg;
        private RichTextBox rtbMessageHelper;
        private ColumnHeader Info;
        private ToolStripButton messageHelpButton;
        private ContextMenuStrip contextMenuStrip_MsgHelper;
        private ToolStripMenuItem toolStripMenuItem_MsgHelperSelect;
        private ToolStripMenuItem toolStripMenuItem_MsgHelperCopy;
        private ContextMenuStrip contextMenuStrip_MsgList;
        private ToolStripMenuItem toolStripMenuItem_MsgListFind;
        private ToolStripMenuItem toolStripMenuItem_MsgListNextFind;
        private ColumnHeader ColorIndex;
        private ColumnHeader MessageIcon;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripProgressBar progressBarLoading;
        private StatusStrip statusStrip;
        private TextBox txtMessageID;
        private TextBox txtInformation;
        private ColumnHeader SystemByte;
        private ToolStripMenuItem goToTheOhterPairToolStripMenuItem;
    }
}



