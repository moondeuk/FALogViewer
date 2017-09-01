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
    public partial class FindForm : Form
    {
        MessageFind messageFind;

        public FindForm(MessageFind messageFind)
        {
            InitializeComponent();
            this.messageFind = messageFind;
            this.messageFind.IsLookAt_ID = true; // Default
            this.messageFind.IsLookAt_DateTime = true; // Default
            this.messageFind.IsLookAt_Info = true; // Default
            this.messageFind.IsLookAt_Description = true; // Default
            this.messageFind.IsLookAt_SystemByte = true; // Default
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (rbDown.Checked == true)
                this.messageFind.IsDownDirection = true;
            else
                this.messageFind.IsDownDirection = false;

            this.messageFind.FindText = txtFindText.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void rbUp_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUp.Checked == true)
                rbDown.Checked = false;
        }

        private void rbDown_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDown.Checked == true)
                rbUp.Checked = false;
        }

        private void OnCheckStateChanged()
        {
            if (cbID.Checked)
                this.messageFind.IsLookAt_ID = true;
            else
                this.messageFind.IsLookAt_ID = false;

            if (cbDateTime.Checked)
                this.messageFind.IsLookAt_DateTime = true;
            else
                this.messageFind.IsLookAt_DateTime = false;

            if (cbInformation.Checked)
                this.messageFind.IsLookAt_Info = true;
            else
                this.messageFind.IsLookAt_Info = false;

            if (cbDescription.Checked)
                this.messageFind.IsLookAt_Description = true;
            else
                this.messageFind.IsLookAt_Description = false;

            if (cbSystemByte.Checked)
                this.messageFind.IsLookAt_SystemByte = true;
            else
                this.messageFind.IsLookAt_SystemByte = false;


            if (cbID.Checked || cbDateTime.Checked || cbInformation.Checked || cbDescription.Checked || cbSystemByte.Checked)
            {
                this.btnFind.Enabled = true;
            }
            else
            {
                this.btnFind.Enabled = false;
            }
        }

        private void cbID_CheckedChanged(object sender, EventArgs e)
        {
            this.OnCheckStateChanged();
        }

        private void cbDateTime_CheckedChanged(object sender, EventArgs e)
        {
            this.OnCheckStateChanged();
        }

        private void cbInformation_CheckedChanged(object sender, EventArgs e)
        {
            this.OnCheckStateChanged();
        }

        private void cbDescription_CheckedChanged(object sender, EventArgs e)
        {
            this.OnCheckStateChanged();
        }

        private void cbSystemByte_CheckedChanged(object sender, EventArgs e)
        {
            this.OnCheckStateChanged();
        }


    }
}
