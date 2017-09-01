namespace FALogViewer
{
    partial class FindForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFindText = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDown = new System.Windows.Forms.RadioButton();
            this.rbUp = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSystemByte = new System.Windows.Forms.CheckBox();
            this.cbDescription = new System.Windows.Forms.CheckBox();
            this.cbInformation = new System.Windows.Forms.CheckBox();
            this.cbDateTime = new System.Windows.Forms.CheckBox();
            this.cbID = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFindText
            // 
            this.txtFindText.Font = new System.Drawing.Font("Arial", 10F);
            this.txtFindText.Location = new System.Drawing.Point(89, 13);
            this.txtFindText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFindText.Name = "txtFindText";
            this.txtFindText.Size = new System.Drawing.Size(261, 23);
            this.txtFindText.TabIndex = 0;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Arial", 10F);
            this.btnFind.Location = new System.Drawing.Point(366, 13);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(110, 42);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find Next";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 10F);
            this.btnCancel.Location = new System.Drawing.Point(366, 63);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 42);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDown);
            this.groupBox1.Controls.Add(this.rbUp);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.groupBox1.Location = new System.Drawing.Point(162, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(156, 52);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
            // 
            // rbDown
            // 
            this.rbDown.AutoSize = true;
            this.rbDown.Checked = true;
            this.rbDown.Location = new System.Drawing.Point(77, 24);
            this.rbDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbDown.Name = "rbDown";
            this.rbDown.Size = new System.Drawing.Size(61, 20);
            this.rbDown.TabIndex = 1;
            this.rbDown.TabStop = true;
            this.rbDown.Text = "Down";
            this.rbDown.UseVisualStyleBackColor = true;
            this.rbDown.CheckedChanged += new System.EventHandler(this.rbDown_CheckedChanged);
            // 
            // rbUp
            // 
            this.rbUp.AutoSize = true;
            this.rbUp.Location = new System.Drawing.Point(13, 24);
            this.rbUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbUp.Name = "rbUp";
            this.rbUp.Size = new System.Drawing.Size(43, 20);
            this.rbUp.TabIndex = 0;
            this.rbUp.Text = "Up";
            this.rbUp.UseVisualStyleBackColor = true;
            this.rbUp.CheckedChanged += new System.EventHandler(this.rbUp_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbSystemByte);
            this.groupBox2.Controls.Add(this.cbDescription);
            this.groupBox2.Controls.Add(this.cbInformation);
            this.groupBox2.Controls.Add(this.cbDateTime);
            this.groupBox2.Controls.Add(this.cbID);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10F);
            this.groupBox2.Location = new System.Drawing.Point(15, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 152);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Look At";
            // 
            // cbSystemByte
            // 
            this.cbSystemByte.AutoSize = true;
            this.cbSystemByte.Checked = true;
            this.cbSystemByte.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSystemByte.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSystemByte.Location = new System.Drawing.Point(10, 124);
            this.cbSystemByte.Name = "cbSystemByte";
            this.cbSystemByte.Size = new System.Drawing.Size(99, 20);
            this.cbSystemByte.TabIndex = 4;
            this.cbSystemByte.Text = "SystemByte";
            this.cbSystemByte.UseVisualStyleBackColor = true;
            this.cbSystemByte.CheckedChanged += new System.EventHandler(this.cbSystemByte_CheckedChanged);
            // 
            // cbDescription
            // 
            this.cbDescription.AutoSize = true;
            this.cbDescription.Checked = true;
            this.cbDescription.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDescription.Location = new System.Drawing.Point(10, 99);
            this.cbDescription.Name = "cbDescription";
            this.cbDescription.Size = new System.Drawing.Size(92, 20);
            this.cbDescription.TabIndex = 3;
            this.cbDescription.Text = "Description";
            this.cbDescription.UseVisualStyleBackColor = true;
            this.cbDescription.CheckedChanged += new System.EventHandler(this.cbDescription_CheckedChanged);
            // 
            // cbInformation
            // 
            this.cbInformation.AutoSize = true;
            this.cbInformation.Checked = true;
            this.cbInformation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbInformation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInformation.Location = new System.Drawing.Point(10, 74);
            this.cbInformation.Name = "cbInformation";
            this.cbInformation.Size = new System.Drawing.Size(90, 20);
            this.cbInformation.TabIndex = 2;
            this.cbInformation.Text = "Information";
            this.cbInformation.UseVisualStyleBackColor = true;
            this.cbInformation.CheckedChanged += new System.EventHandler(this.cbInformation_CheckedChanged);
            // 
            // cbDateTime
            // 
            this.cbDateTime.AutoSize = true;
            this.cbDateTime.Checked = true;
            this.cbDateTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDateTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDateTime.Location = new System.Drawing.Point(10, 49);
            this.cbDateTime.Name = "cbDateTime";
            this.cbDateTime.Size = new System.Drawing.Size(82, 20);
            this.cbDateTime.TabIndex = 1;
            this.cbDateTime.Text = "DateTime";
            this.cbDateTime.UseVisualStyleBackColor = true;
            this.cbDateTime.CheckedChanged += new System.EventHandler(this.cbDateTime_CheckedChanged);
            // 
            // cbID
            // 
            this.cbID.AutoSize = true;
            this.cbID.Checked = true;
            this.cbID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbID.Location = new System.Drawing.Point(10, 24);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(39, 20);
            this.cbID.TabIndex = 0;
            this.cbID.Text = "ID";
            this.cbID.UseVisualStyleBackColor = true;
            this.cbID.CheckedChanged += new System.EventHandler(this.cbID_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Find what:";
            // 
            // FindForm
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(491, 220);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFindText);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFindText;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDown;
        private System.Windows.Forms.RadioButton rbUp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbDateTime;
        private System.Windows.Forms.CheckBox cbID;
        private System.Windows.Forms.CheckBox cbSystemByte;
        private System.Windows.Forms.CheckBox cbDescription;
        private System.Windows.Forms.CheckBox cbInformation;
        private System.Windows.Forms.Label label1;
    }
}