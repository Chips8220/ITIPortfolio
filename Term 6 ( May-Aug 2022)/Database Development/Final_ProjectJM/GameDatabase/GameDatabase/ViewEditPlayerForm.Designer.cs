
namespace GameDatabase
{
    partial class frmGameDB
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHDamage = new System.Windows.Forms.TextBox();
            this.txtLDamage = new System.Windows.Forms.TextBox();
            this.txtMP = new System.Windows.Forms.TextBox();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.lblHDamage = new System.Windows.Forms.Label();
            this.lblLDamage = new System.Windows.Forms.Label();
            this.lblMP = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblPName = new System.Windows.Forms.Label();
            this.lblTableName = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHDamage);
            this.groupBox1.Controls.Add(this.txtLDamage);
            this.groupBox1.Controls.Add(this.txtMP);
            this.groupBox1.Controls.Add(this.txtHP);
            this.groupBox1.Controls.Add(this.txtPName);
            this.groupBox1.Controls.Add(this.lblHDamage);
            this.groupBox1.Controls.Add(this.lblLDamage);
            this.groupBox1.Controls.Add(this.lblMP);
            this.groupBox1.Controls.Add(this.lblHP);
            this.groupBox1.Controls.Add(this.lblPName);
            this.groupBox1.Controls.Add(this.lblTableName);
            this.groupBox1.Location = new System.Drawing.Point(69, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtHDamage
            // 
            this.txtHDamage.Location = new System.Drawing.Point(94, 148);
            this.txtHDamage.Name = "txtHDamage";
            this.txtHDamage.Size = new System.Drawing.Size(100, 20);
            this.txtHDamage.TabIndex = 5;
            // 
            // txtLDamage
            // 
            this.txtLDamage.Location = new System.Drawing.Point(94, 122);
            this.txtLDamage.Name = "txtLDamage";
            this.txtLDamage.Size = new System.Drawing.Size(100, 20);
            this.txtLDamage.TabIndex = 4;
            // 
            // txtMP
            // 
            this.txtMP.Location = new System.Drawing.Point(94, 96);
            this.txtMP.Name = "txtMP";
            this.txtMP.Size = new System.Drawing.Size(100, 20);
            this.txtMP.TabIndex = 3;
            // 
            // txtHP
            // 
            this.txtHP.Location = new System.Drawing.Point(94, 70);
            this.txtHP.Name = "txtHP";
            this.txtHP.Size = new System.Drawing.Size(100, 20);
            this.txtHP.TabIndex = 2;
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(94, 44);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(100, 20);
            this.txtPName.TabIndex = 1;
            this.txtPName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPName_KeyPress);
            // 
            // lblHDamage
            // 
            this.lblHDamage.AutoSize = true;
            this.lblHDamage.Location = new System.Drawing.Point(7, 148);
            this.lblHDamage.Name = "lblHDamage";
            this.lblHDamage.Size = new System.Drawing.Size(81, 13);
            this.lblHDamage.TabIndex = 5;
            this.lblHDamage.Text = "Higher Damage";
            // 
            // lblLDamage
            // 
            this.lblLDamage.AutoSize = true;
            this.lblLDamage.Location = new System.Drawing.Point(7, 122);
            this.lblLDamage.Name = "lblLDamage";
            this.lblLDamage.Size = new System.Drawing.Size(79, 13);
            this.lblLDamage.TabIndex = 4;
            this.lblLDamage.Text = "Lower Damage";
            // 
            // lblMP
            // 
            this.lblMP.AutoSize = true;
            this.lblMP.Location = new System.Drawing.Point(7, 96);
            this.lblMP.Name = "lblMP";
            this.lblMP.Size = new System.Drawing.Size(66, 13);
            this.lblMP.TabIndex = 3;
            this.lblMP.Text = "Mana Points";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(6, 70);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(52, 13);
            this.lblHP.TabIndex = 2;
            this.lblHP.Text = "Hit Points";
            // 
            // lblPName
            // 
            this.lblPName.AutoSize = true;
            this.lblPName.Location = new System.Drawing.Point(7, 44);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(67, 13);
            this.lblPName.TabIndex = 1;
            this.lblPName.Text = "Player Name";
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Location = new System.Drawing.Point(80, 16);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(36, 13);
            this.lblTableName.TabIndex = 0;
            this.lblTableName.Text = "Player";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(222, 294);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 19;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "Do&ne";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(141, 294);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(60, 294);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 17;
            this.btnAddNew.TabStop = false;
            this.btnAddNew.Text = "&Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(222, 265);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(141, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(60, 265);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(197, 236);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 21;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "Next =>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(91, 236);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 20;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Text = "<= Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(358, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuFile
            // 
            this.MnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewQuery});
            this.MnuFile.Name = "MnuFile";
            this.MnuFile.Size = new System.Drawing.Size(37, 20);
            this.MnuFile.Text = "File";
            // 
            // mnuNewQuery
            // 
            this.mnuNewQuery.Name = "mnuNewQuery";
            this.mnuNewQuery.Size = new System.Drawing.Size(133, 22);
            this.mnuNewQuery.Text = "New Query";
            this.mnuNewQuery.Click += new System.EventHandler(this.mnuNewQuery_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmGameDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmGameDB";
            this.Text = "Game Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGameDB_FormClosing);
            this.Load += new System.EventHandler(this.frmGameDB_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHDamage;
        private System.Windows.Forms.TextBox txtLDamage;
        private System.Windows.Forms.TextBox txtMP;
        private System.Windows.Forms.TextBox txtHP;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label lblHDamage;
        private System.Windows.Forms.Label lblLDamage;
        private System.Windows.Forms.Label lblMP;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblPName;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNewQuery;
        private System.Windows.Forms.Button button1;
    }
}

