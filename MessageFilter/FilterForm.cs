using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FALogViewer
{
    public partial class FilterForm : Form
    {
        private MessageFilter messageFilter;

        public FilterForm(MessageFilter messageFilter)
        {
            InitializeComponent();

            this.messageFilter = messageFilter;
        }

        private void ShowList()
        {
            lvFilterMsg_Include.BeginUpdate();
            lvFilterMsg_Include.Items.Clear();

            foreach(string msg in this.messageFilter.IncludeMessages)
            {
                ListViewItem item = new ListViewItem(msg); 
                lvFilterMsg_Include.Items.Add(item);
            }
            lvFilterMsg_Include.EndUpdate();

            lvFilterMsg_Exclude.BeginUpdate();
            lvFilterMsg_Exclude.Items.Clear();

            foreach (string msg in this.messageFilter.ExcludeMessages)
            {
                ListViewItem item = new ListViewItem(msg);
                lvFilterMsg_Exclude.Items.Add(item);
            }
            lvFilterMsg_Exclude.EndUpdate();
        }

        private void FilterForm_Load(object sender, EventArgs e)
        {
            this.ShowList();
            this.checkBox_Include.Checked = messageFilter.IsIncludeEnable;
            this.checkBox_Exclude.Checked = messageFilter.IsExcludeEnable;
        }

        private void btnAdd_Include_Click(object sender, EventArgs e)
        {
            this.AddToInclude("S" + txtStream_Include.Text + ", F" + txtFunction_Include.Text);
            this.txtStream_Include.Text = string.Empty;
            this.txtFunction_Include.Text = string.Empty;
        }

        private void AddToInclude(string messageID)
        {
            foreach (string message in this.messageFilter.IncludeMessages)
            {
                if (message == messageID) return;  // Duplication Check
            }

            this.messageFilter.IncludeMessages.Add(messageID);
            this.ShowList();
        }

        private void AddToExclude(string messageID)
        {
            foreach (string message in this.messageFilter.ExcludeMessages)
            {
                if (message == messageID) return;  // Duplication Check
            }

            this.messageFilter.ExcludeMessages.Add(messageID);
            this.ShowList();
        }

        private void btnDelete_Include_Click(object sender, EventArgs e)
        {
            if (lvFilterMsg_Include.SelectedItems.Count > 0)
            {
                int index = lvFilterMsg_Include.SelectedIndices[0];
                this.messageFilter.IncludeMessages.RemoveAt(index);
                this.ShowList();
            }
        }

        private void btnAdd_Exclude_Click(object sender, EventArgs e)
        {
            AddToExclude("S" + txtStream_Exclude.Text + ", F" + txtFunction_Exclude.Text);

            this.txtStream_Exclude.Text = string.Empty;
            this.txtFunction_Exclude.Text = string.Empty;
        }

        private void btnDelete_Exclude_Click(object sender, EventArgs e)
        {
            if (lvFilterMsg_Exclude.SelectedItems.Count > 0)
            {
                int index = lvFilterMsg_Exclude.SelectedIndices[0];
                this.messageFilter.ExcludeMessages.RemoveAt(index);
                this.ShowList();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SetEnableInclude(bool isEnable)
        {
            checkBox_Include.Checked = isEnable;
            messageFilter.IsIncludeEnable = isEnable;
        }

        private void SetEnableExclude(bool isEnable)
        {
            checkBox_Exclude.Checked = isEnable;
            messageFilter.IsExcludeEnable = isEnable;
        }

        private void checkBox_Exclude_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_Exclude.Checked == true)
            {
                SetEnableExclude(true);
                SetEnableInclude(false);

                this.pbExclude.BackColor = Color.Yellow;
            }
            else
            {
                messageFilter.IsExcludeEnable = false;
                this.pbExclude.BackColor = Color.FromKnownColor(KnownColor.Control);
            }
        }

        private void checkBox_Include_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_Include.Checked == true)
            {
                SetEnableExclude(false);
                SetEnableInclude(true);

                this.pbInclude.BackColor = Color.Yellow;
            }
            else
            {
                messageFilter.IsIncludeEnable = false;
                this.pbInclude.BackColor = Color.FromKnownColor(KnownColor.Control);
            }
        }

        private void btnSwitchRight_Click(object sender, EventArgs e)
        {
            if (lvFilterMsg_Include.SelectedItems.Count > 0)
            {
                int index = lvFilterMsg_Include.SelectedIndices[0];
                AddToExclude(lvFilterMsg_Include.Items[index].Text);
            }
        }

        private void btnSwitchLeft_Click(object sender, EventArgs e)
        {
            if (lvFilterMsg_Exclude.SelectedItems.Count > 0)
            {
                int index = lvFilterMsg_Exclude.SelectedIndices[0];
                AddToInclude(lvFilterMsg_Exclude.Items[index].Text);
            }
        }
    }
}
