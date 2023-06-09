namespace Example_6_9
{
  partial class frmAuthors
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
      this.label1 = new System.Windows.Forms.Label();
      this.txtAuthorID = new System.Windows.Forms.TextBox();
      this.txtAuthorName = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtYearBorn = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.btnPrevious = new System.Windows.Forms.Button();
      this.btnNext = new System.Windows.Forms.Button();
      this.btnEdit = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnAddNew = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnDone = new System.Windows.Forms.Button();
      this.hlpAuthors = new System.Windows.Forms.HelpProvider();
      this.btnHelp = new System.Windows.Forms.Button();
      this.btnLast = new System.Windows.Forms.Button();
      this.btnFirst = new System.Windows.Forms.Button();
      this.grpFindAuthor = new System.Windows.Forms.GroupBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtFind = new System.Windows.Forms.TextBox();
      this.btnFind = new System.Windows.Forms.Button();
      this.grpFindAuthor.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 19);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(52, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Author ID";
      // 
      // txtAuthorID
      // 
      this.txtAuthorID.BackColor = System.Drawing.Color.White;
      this.txtAuthorID.Location = new System.Drawing.Point(89, 16);
      this.txtAuthorID.Name = "txtAuthorID";
      this.txtAuthorID.ReadOnly = true;
      this.txtAuthorID.Size = new System.Drawing.Size(100, 20);
      this.txtAuthorID.TabIndex = 1;
      this.txtAuthorID.TabStop = false;
      // 
      // txtAuthorName
      // 
      this.txtAuthorName.BackColor = System.Drawing.Color.White;
      this.txtAuthorName.Location = new System.Drawing.Point(89, 42);
      this.txtAuthorName.Name = "txtAuthorName";
      this.txtAuthorName.ReadOnly = true;
      this.txtAuthorName.Size = new System.Drawing.Size(236, 20);
      this.txtAuthorName.TabIndex = 1;
      this.txtAuthorName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAuthorName_KeyPress);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 45);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(69, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Author Name";
      // 
      // txtYearBorn
      // 
      this.txtYearBorn.BackColor = System.Drawing.Color.White;
      this.txtYearBorn.Location = new System.Drawing.Point(89, 68);
      this.txtYearBorn.MaxLength = 4;
      this.txtYearBorn.Name = "txtYearBorn";
      this.txtYearBorn.ReadOnly = true;
      this.txtYearBorn.Size = new System.Drawing.Size(100, 20);
      this.txtYearBorn.TabIndex = 2;
      this.txtYearBorn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYearBorn_KeyPress);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 71);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(54, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Year Born";
      // 
      // btnPrevious
      // 
      this.btnPrevious.Location = new System.Drawing.Point(89, 104);
      this.btnPrevious.Name = "btnPrevious";
      this.btnPrevious.Size = new System.Drawing.Size(75, 23);
      this.btnPrevious.TabIndex = 6;
      this.btnPrevious.TabStop = false;
      this.btnPrevious.Text = "< Previous";
      this.btnPrevious.UseVisualStyleBackColor = true;
      this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
      // 
      // btnNext
      // 
      this.btnNext.Location = new System.Drawing.Point(170, 104);
      this.btnNext.Name = "btnNext";
      this.btnNext.Size = new System.Drawing.Size(75, 23);
      this.btnNext.TabIndex = 7;
      this.btnNext.TabStop = false;
      this.btnNext.Text = "Next >";
      this.btnNext.UseVisualStyleBackColor = true;
      this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
      // 
      // btnEdit
      // 
      this.btnEdit.Location = new System.Drawing.Point(54, 133);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new System.Drawing.Size(75, 23);
      this.btnEdit.TabIndex = 8;
      this.btnEdit.TabStop = false;
      this.btnEdit.Text = "&Edit";
      this.btnEdit.UseVisualStyleBackColor = true;
      this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(135, 133);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 9;
      this.btnSave.TabStop = false;
      this.btnSave.Text = "&Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(216, 133);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 10;
      this.btnCancel.TabStop = false;
      this.btnCancel.Text = "&Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnAddNew
      // 
      this.btnAddNew.Location = new System.Drawing.Point(54, 162);
      this.btnAddNew.Name = "btnAddNew";
      this.btnAddNew.Size = new System.Drawing.Size(75, 23);
      this.btnAddNew.TabIndex = 11;
      this.btnAddNew.TabStop = false;
      this.btnAddNew.Text = "&Add New";
      this.btnAddNew.UseVisualStyleBackColor = true;
      this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(135, 162);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(75, 23);
      this.btnDelete.TabIndex = 12;
      this.btnDelete.TabStop = false;
      this.btnDelete.Text = "&Delete";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // btnDone
      // 
      this.btnDone.Location = new System.Drawing.Point(216, 162);
      this.btnDone.Name = "btnDone";
      this.btnDone.Size = new System.Drawing.Size(75, 23);
      this.btnDone.TabIndex = 13;
      this.btnDone.TabStop = false;
      this.btnDone.Text = "D&one";
      this.btnDone.UseVisualStyleBackColor = true;
      this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
      // 
      // btnHelp
      // 
      this.btnHelp.Location = new System.Drawing.Point(216, 191);
      this.btnHelp.Name = "btnHelp";
      this.btnHelp.Size = new System.Drawing.Size(75, 23);
      this.btnHelp.TabIndex = 14;
      this.btnHelp.TabStop = false;
      this.btnHelp.Text = "&Help";
      this.btnHelp.UseVisualStyleBackColor = true;
      this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
      // 
      // btnLast
      // 
      this.btnLast.Location = new System.Drawing.Point(250, 104);
      this.btnLast.Name = "btnLast";
      this.btnLast.Size = new System.Drawing.Size(75, 23);
      this.btnLast.TabIndex = 15;
      this.btnLast.TabStop = false;
      this.btnLast.Text = "Last >|";
      this.btnLast.UseVisualStyleBackColor = true;
      this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
      // 
      // btnFirst
      // 
      this.btnFirst.Location = new System.Drawing.Point(8, 104);
      this.btnFirst.Name = "btnFirst";
      this.btnFirst.Size = new System.Drawing.Size(75, 23);
      this.btnFirst.TabIndex = 16;
      this.btnFirst.TabStop = false;
      this.btnFirst.Text = "|< First";
      this.btnFirst.UseVisualStyleBackColor = true;
      this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
      // 
      // grpFindAuthor
      // 
      this.grpFindAuthor.Controls.Add(this.btnFind);
      this.grpFindAuthor.Controls.Add(this.txtFind);
      this.grpFindAuthor.Controls.Add(this.label4);
      this.grpFindAuthor.Location = new System.Drawing.Point(8, 193);
      this.grpFindAuthor.Name = "grpFindAuthor";
      this.grpFindAuthor.Size = new System.Drawing.Size(200, 77);
      this.grpFindAuthor.TabIndex = 17;
      this.grpFindAuthor.TabStop = false;
      this.grpFindAuthor.Text = "Find Author";
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(11, 16);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(91, 50);
      this.label4.TabIndex = 0;
      this.label4.Text = "Type first few letters of Author Name";
      // 
      // txtFind
      // 
      this.txtFind.Location = new System.Drawing.Point(108, 16);
      this.txtFind.Name = "txtFind";
      this.txtFind.Size = new System.Drawing.Size(73, 20);
      this.txtFind.TabIndex = 18;
      this.txtFind.TabStop = false;
      // 
      // btnFind
      // 
      this.btnFind.Location = new System.Drawing.Point(108, 42);
      this.btnFind.Name = "btnFind";
      this.btnFind.Size = new System.Drawing.Size(73, 23);
      this.btnFind.TabIndex = 19;
      this.btnFind.TabStop = false;
      this.btnFind.Text = "Find";
      this.btnFind.UseVisualStyleBackColor = true;
      this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
      // 
      // frmAuthors
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(338, 278);
      this.Controls.Add(this.grpFindAuthor);
      this.Controls.Add(this.btnFirst);
      this.Controls.Add(this.btnLast);
      this.Controls.Add(this.btnHelp);
      this.Controls.Add(this.btnDone);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.btnAddNew);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.btnEdit);
      this.Controls.Add(this.btnNext);
      this.Controls.Add(this.btnPrevious);
      this.Controls.Add(this.txtYearBorn);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtAuthorName);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtAuthorID);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.hlpAuthors.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
      this.Name = "frmAuthors";
      this.hlpAuthors.SetShowHelp(this, true);
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Authors";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAuthors_FormClosing);
      this.Load += new System.EventHandler(this.frmAuthors_Load);
      this.grpFindAuthor.ResumeLayout(false);
      this.grpFindAuthor.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtAuthorID;
    private System.Windows.Forms.TextBox txtAuthorName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtYearBorn;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnPrevious;
    private System.Windows.Forms.Button btnNext;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnAddNew;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnDone;
    private System.Windows.Forms.HelpProvider hlpAuthors;
    private System.Windows.Forms.Button btnHelp;
    private System.Windows.Forms.Button btnLast;
    private System.Windows.Forms.Button btnFirst;
    private System.Windows.Forms.GroupBox grpFindAuthor;
    private System.Windows.Forms.Button btnFind;
    private System.Windows.Forms.TextBox txtFind;
    private System.Windows.Forms.Label label4;
  }
}

