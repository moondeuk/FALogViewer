namespace FALogViewer
{
    partial class FilterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterForm));
            this.lvFilterMsg_Include = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStream_Include = new System.Windows.Forms.TextBox();
            this.txtFunction_Include = new System.Windows.Forms.TextBox();
            this.btnAdd_Include = new System.Windows.Forms.Button();
            this.btnDelete_Include = new System.Windows.Forms.Button();
            this.btnDelete_Exclude = new System.Windows.Forms.Button();
            this.btnAdd_Exclude = new System.Windows.Forms.Button();
            this.txtFunction_Exclude = new System.Windows.Forms.TextBox();
            this.txtStream_Exclude = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lvFilterMsg_Exclude = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.btnSwitchRight = new System.Windows.Forms.Button();
            this.btnSwitchLeft = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.checkBox_Include = new System.Windows.Forms.CheckBox();
            this.checkBox_Exclude = new System.Windows.Forms.CheckBox();
            this.pbInclude = new System.Windows.Forms.PictureBox();
            this.pbExclude = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbInclude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExclude)).BeginInit();
            this.SuspendLayout();
            // 
            // lvFilterMsg_Include
            // 
            this.lvFilterMsg_Include.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvFilterMsg_Include.Location = new System.Drawing.Point(12, 51);
            this.lvFilterMsg_Include.Name = "lvFilterMsg_Include";
            this.lvFilterMsg_Include.Size = new System.Drawing.Size(269, 313);
            this.lvFilterMsg_Include.TabIndex = 0;
            this.lvFilterMsg_Include.UseCompatibleStateImageBehavior = false;
            this.lvFilterMsg_Include.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Include Message";
            this.columnHeader1.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stream :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Function :";
            // 
            // txtStream_Include
            // 
            this.txtStream_Include.Location = new System.Drawing.Point(99, 388);
            this.txtStream_Include.Name = "txtStream_Include";
            this.txtStream_Include.Size = new System.Drawing.Size(54, 21);
            this.txtStream_Include.TabIndex = 4;
            // 
            // txtFunction_Include
            // 
            this.txtFunction_Include.Location = new System.Drawing.Point(99, 430);
            this.txtFunction_Include.Name = "txtFunction_Include";
            this.txtFunction_Include.Size = new System.Drawing.Size(54, 21);
            this.txtFunction_Include.TabIndex = 5;
            // 
            // btnAdd_Include
            // 
            this.btnAdd_Include.Location = new System.Drawing.Point(162, 384);
            this.btnAdd_Include.Name = "btnAdd_Include";
            this.btnAdd_Include.Size = new System.Drawing.Size(41, 73);
            this.btnAdd_Include.TabIndex = 6;
            this.btnAdd_Include.Text = "Add";
            this.btnAdd_Include.UseVisualStyleBackColor = true;
            this.btnAdd_Include.Click += new System.EventHandler(this.btnAdd_Include_Click);
            // 
            // btnDelete_Include
            // 
            this.btnDelete_Include.Location = new System.Drawing.Point(215, 384);
            this.btnDelete_Include.Name = "btnDelete_Include";
            this.btnDelete_Include.Size = new System.Drawing.Size(67, 73);
            this.btnDelete_Include.TabIndex = 7;
            this.btnDelete_Include.Text = "Delete";
            this.btnDelete_Include.UseVisualStyleBackColor = true;
            this.btnDelete_Include.Click += new System.EventHandler(this.btnDelete_Include_Click);
            // 
            // btnDelete_Exclude
            // 
            this.btnDelete_Exclude.Location = new System.Drawing.Point(536, 384);
            this.btnDelete_Exclude.Name = "btnDelete_Exclude";
            this.btnDelete_Exclude.Size = new System.Drawing.Size(67, 73);
            this.btnDelete_Exclude.TabIndex = 14;
            this.btnDelete_Exclude.Text = "Delete";
            this.btnDelete_Exclude.UseVisualStyleBackColor = true;
            this.btnDelete_Exclude.Click += new System.EventHandler(this.btnDelete_Exclude_Click);
            // 
            // btnAdd_Exclude
            // 
            this.btnAdd_Exclude.Location = new System.Drawing.Point(483, 384);
            this.btnAdd_Exclude.Name = "btnAdd_Exclude";
            this.btnAdd_Exclude.Size = new System.Drawing.Size(41, 73);
            this.btnAdd_Exclude.TabIndex = 13;
            this.btnAdd_Exclude.Text = "Add";
            this.btnAdd_Exclude.UseVisualStyleBackColor = true;
            this.btnAdd_Exclude.Click += new System.EventHandler(this.btnAdd_Exclude_Click);
            // 
            // txtFunction_Exclude
            // 
            this.txtFunction_Exclude.Location = new System.Drawing.Point(420, 430);
            this.txtFunction_Exclude.Name = "txtFunction_Exclude";
            this.txtFunction_Exclude.Size = new System.Drawing.Size(54, 21);
            this.txtFunction_Exclude.TabIndex = 12;
            // 
            // txtStream_Exclude
            // 
            this.txtStream_Exclude.Location = new System.Drawing.Point(420, 388);
            this.txtStream_Exclude.Name = "txtStream_Exclude";
            this.txtStream_Exclude.Size = new System.Drawing.Size(54, 21);
            this.txtStream_Exclude.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Function :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stream :";
            // 
            // lvFilterMsg_Exclude
            // 
            this.lvFilterMsg_Exclude.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lvFilterMsg_Exclude.Location = new System.Drawing.Point(333, 51);
            this.lvFilterMsg_Exclude.Name = "lvFilterMsg_Exclude";
            this.lvFilterMsg_Exclude.Size = new System.Drawing.Size(269, 313);
            this.lvFilterMsg_Exclude.TabIndex = 8;
            this.lvFilterMsg_Exclude.UseCompatibleStateImageBehavior = false;
            this.lvFilterMsg_Exclude.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Exclude Message";
            this.columnHeader2.Width = 200;
            // 
            // btnSwitchRight
            // 
            this.btnSwitchRight.Image = ((System.Drawing.Image)(resources.GetObject("btnSwitchRight.Image")));
            this.btnSwitchRight.Location = new System.Drawing.Point(288, 141);
            this.btnSwitchRight.Name = "btnSwitchRight";
            this.btnSwitchRight.Size = new System.Drawing.Size(37, 45);
            this.btnSwitchRight.TabIndex = 15;
            this.btnSwitchRight.UseVisualStyleBackColor = true;
            this.btnSwitchRight.Click += new System.EventHandler(this.btnSwitchRight_Click);
            // 
            // btnSwitchLeft
            // 
            this.btnSwitchLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnSwitchLeft.Image")));
            this.btnSwitchLeft.Location = new System.Drawing.Point(288, 206);
            this.btnSwitchLeft.Name = "btnSwitchLeft";
            this.btnSwitchLeft.Size = new System.Drawing.Size(37, 45);
            this.btnSwitchLeft.TabIndex = 15;
            this.btnSwitchLeft.UseVisualStyleBackColor = true;
            this.btnSwitchLeft.Click += new System.EventHandler(this.btnSwitchLeft_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(405, 489);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(93, 41);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(509, 489);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 41);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // checkBox_Include
            // 
            this.checkBox_Include.AutoSize = true;
            this.checkBox_Include.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox_Include.Font = new System.Drawing.Font("Arial monospaced for SAP", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Include.Location = new System.Drawing.Point(13, 6);
            this.checkBox_Include.Name = "checkBox_Include";
            this.checkBox_Include.Size = new System.Drawing.Size(209, 28);
            this.checkBox_Include.TabIndex = 18;
            this.checkBox_Include.Text = "Enable Include";
            this.checkBox_Include.UseVisualStyleBackColor = true;
            this.checkBox_Include.CheckedChanged += new System.EventHandler(this.checkBox_Include_CheckedChanged);
            // 
            // checkBox_Exclude
            // 
            this.checkBox_Exclude.AutoSize = true;
            this.checkBox_Exclude.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox_Exclude.Font = new System.Drawing.Font("Arial monospaced for SAP", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Exclude.Location = new System.Drawing.Point(333, 9);
            this.checkBox_Exclude.Name = "checkBox_Exclude";
            this.checkBox_Exclude.Size = new System.Drawing.Size(209, 28);
            this.checkBox_Exclude.TabIndex = 19;
            this.checkBox_Exclude.Text = "Enable Exclude";
            this.checkBox_Exclude.UseVisualStyleBackColor = true;
            this.checkBox_Exclude.CheckedChanged += new System.EventHandler(this.checkBox_Exclude_CheckedChanged);
            // 
            // pbInclude
            // 
            this.pbInclude.BackColor = System.Drawing.SystemColors.Control;
            this.pbInclude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbInclude.Location = new System.Drawing.Point(7, 45);
            this.pbInclude.Name = "pbInclude";
            this.pbInclude.Size = new System.Drawing.Size(280, 424);
            this.pbInclude.TabIndex = 20;
            this.pbInclude.TabStop = false;
            // 
            // pbExclude
            // 
            this.pbExclude.BackColor = System.Drawing.SystemColors.Control;
            this.pbExclude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbExclude.Location = new System.Drawing.Point(328, 45);
            this.pbExclude.Name = "pbExclude";
            this.pbExclude.Size = new System.Drawing.Size(280, 424);
            this.pbExclude.TabIndex = 21;
            this.pbExclude.TabStop = false;
            // 
            // FilterForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(618, 547);
            this.Controls.Add(this.checkBox_Exclude);
            this.Controls.Add(this.checkBox_Include);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnSwitchLeft);
            this.Controls.Add(this.btnSwitchRight);
            this.Controls.Add(this.btnDelete_Exclude);
            this.Controls.Add(this.btnAdd_Exclude);
            this.Controls.Add(this.txtFunction_Exclude);
            this.Controls.Add(this.txtStream_Exclude);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lvFilterMsg_Exclude);
            this.Controls.Add(this.btnDelete_Include);
            this.Controls.Add(this.btnAdd_Include);
            this.Controls.Add(this.txtFunction_Include);
            this.Controls.Add(this.txtStream_Include);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvFilterMsg_Include);
            this.Controls.Add(this.pbInclude);
            this.Controls.Add(this.pbExclude);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Name = "FilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Filter Message";
            this.Load += new System.EventHandler(this.FilterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbInclude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExclude)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvFilterMsg_Include;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStream_Include;
        private System.Windows.Forms.TextBox txtFunction_Include;
        private System.Windows.Forms.Button btnAdd_Include;
        private System.Windows.Forms.Button btnDelete_Include;
        private System.Windows.Forms.Button btnDelete_Exclude;
        private System.Windows.Forms.Button btnAdd_Exclude;
        private System.Windows.Forms.TextBox txtFunction_Exclude;
        private System.Windows.Forms.TextBox txtStream_Exclude;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvFilterMsg_Exclude;
        private System.Windows.Forms.Button btnSwitchRight;
        private System.Windows.Forms.Button btnSwitchLeft;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox checkBox_Include;
        private System.Windows.Forms.CheckBox checkBox_Exclude;
        private System.Windows.Forms.PictureBox pbInclude;
        private System.Windows.Forms.PictureBox pbExclude;
    }
}