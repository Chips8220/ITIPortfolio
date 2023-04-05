
namespace MidtermLab
{
    partial class AddNewStudent
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
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.lblTerm = new System.Windows.Forms.Label();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.txtBirthdate = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblGPA = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreateStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTerm
            // 
            this.txtTerm.Enabled = false;
            this.txtTerm.Location = new System.Drawing.Point(117, 179);
            this.txtTerm.Multiline = true;
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(139, 20);
            this.txtTerm.TabIndex = 35;
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new System.Drawing.Point(33, 186);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(31, 13);
            this.lblTerm.TabIndex = 34;
            this.lblTerm.Text = "Term";
            // 
            // txtGPA
            // 
            this.txtGPA.Enabled = false;
            this.txtGPA.Location = new System.Drawing.Point(117, 140);
            this.txtGPA.Multiline = true;
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(139, 20);
            this.txtGPA.TabIndex = 33;
            // 
            // txtBirthdate
            // 
            this.txtBirthdate.BackColor = System.Drawing.SystemColors.Control;
            this.txtBirthdate.Location = new System.Drawing.Point(117, 98);
            this.txtBirthdate.Multiline = true;
            this.txtBirthdate.Name = "txtBirthdate";
            this.txtBirthdate.Size = new System.Drawing.Size(139, 20);
            this.txtBirthdate.TabIndex = 32;
            // 
            // txtLName
            // 
            this.txtLName.BackColor = System.Drawing.Color.White;
            this.txtLName.Location = new System.Drawing.Point(117, 56);
            this.txtLName.Multiline = true;
            this.txtLName.Name = "txtLName";
            this.txtLName.ReadOnly = true;
            this.txtLName.Size = new System.Drawing.Size(139, 20);
            this.txtLName.TabIndex = 31;
            // 
            // txtFName
            // 
            this.txtFName.BackColor = System.Drawing.Color.White;
            this.txtFName.Location = new System.Drawing.Point(117, 18);
            this.txtFName.Multiline = true;
            this.txtFName.Name = "txtFName";
            this.txtFName.ReadOnly = true;
            this.txtFName.Size = new System.Drawing.Size(139, 20);
            this.txtFName.TabIndex = 30;
            // 
            // lblGPA
            // 
            this.lblGPA.AutoSize = true;
            this.lblGPA.Location = new System.Drawing.Point(33, 147);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(29, 13);
            this.lblGPA.TabIndex = 29;
            this.lblGPA.Text = "GPA";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(33, 105);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(49, 13);
            this.lblBirthdate.TabIndex = 28;
            this.lblBirthdate.Text = "Birthdate";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(33, 63);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 27;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(33, 21);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 26;
            this.lblFirstName.Text = "First Name";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(159, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCreateStudent.Location = new System.Drawing.Point(64, 226);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(84, 35);
            this.btnCreateStudent.TabIndex = 36;
            this.btnCreateStudent.TabStop = false;
            this.btnCreateStudent.Text = "Create New Record";
            this.btnCreateStudent.UseVisualStyleBackColor = true;
            this.btnCreateStudent.Click += new System.EventHandler(this.btnCreateStudent_Click);
            // 
            // AddNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 273);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateStudent);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.txtGPA);
            this.Controls.Add(this.txtBirthdate);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblGPA);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "AddNewStudent";
            this.Text = "AddNewStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.TextBox txtBirthdate;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreateStudent;
    }
}