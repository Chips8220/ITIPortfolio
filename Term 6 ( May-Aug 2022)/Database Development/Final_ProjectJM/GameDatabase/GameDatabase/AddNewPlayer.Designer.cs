
namespace GameDatabase
{
    partial class AddNewPlayer
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreatePlayer = new System.Windows.Forms.Button();
            this.grpNewPlayer = new System.Windows.Forms.GroupBox();
            this.txtNewPName = new System.Windows.Forms.TextBox();
            this.lblNewPName = new System.Windows.Forms.Label();
            this.lblNewRow = new System.Windows.Forms.Label();
            this.grpNewPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(209, 151);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreatePlayer
            // 
            this.btnCreatePlayer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCreatePlayer.Location = new System.Drawing.Point(114, 151);
            this.btnCreatePlayer.Name = "btnCreatePlayer";
            this.btnCreatePlayer.Size = new System.Drawing.Size(84, 35);
            this.btnCreatePlayer.TabIndex = 24;
            this.btnCreatePlayer.TabStop = false;
            this.btnCreatePlayer.Text = "Create New Player";
            this.btnCreatePlayer.UseVisualStyleBackColor = true;
            this.btnCreatePlayer.Click += new System.EventHandler(this.btnCreatePlayer_Click);
            // 
            // grpNewPlayer
            // 
            this.grpNewPlayer.Controls.Add(this.txtNewPName);
            this.grpNewPlayer.Controls.Add(this.lblNewPName);
            this.grpNewPlayer.Controls.Add(this.lblNewRow);
            this.grpNewPlayer.Location = new System.Drawing.Point(79, 46);
            this.grpNewPlayer.Name = "grpNewPlayer";
            this.grpNewPlayer.Size = new System.Drawing.Size(240, 83);
            this.grpNewPlayer.TabIndex = 22;
            this.grpNewPlayer.TabStop = false;
            // 
            // txtNewPName
            // 
            this.txtNewPName.Location = new System.Drawing.Point(105, 44);
            this.txtNewPName.Name = "txtNewPName";
            this.txtNewPName.Size = new System.Drawing.Size(100, 20);
            this.txtNewPName.TabIndex = 1;
            // 
            // lblNewPName
            // 
            this.lblNewPName.AutoSize = true;
            this.lblNewPName.Location = new System.Drawing.Point(7, 44);
            this.lblNewPName.Name = "lblNewPName";
            this.lblNewPName.Size = new System.Drawing.Size(95, 13);
            this.lblNewPName.TabIndex = 1;
            this.lblNewPName.Text = "New Player Name:";
            // 
            // lblNewRow
            // 
            this.lblNewRow.AutoSize = true;
            this.lblNewRow.Location = new System.Drawing.Point(111, 16);
            this.lblNewRow.Name = "lblNewRow";
            this.lblNewRow.Size = new System.Drawing.Size(83, 13);
            this.lblNewRow.TabIndex = 0;
            this.lblNewRow.Text = "Add New Player";
            // 
            // AddNewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 252);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreatePlayer);
            this.Controls.Add(this.grpNewPlayer);
            this.Name = "AddNewPlayer";
            this.Text = "Add New Player";
            this.grpNewPlayer.ResumeLayout(false);
            this.grpNewPlayer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreatePlayer;
        private System.Windows.Forms.GroupBox grpNewPlayer;
        private System.Windows.Forms.TextBox txtNewPName;
        private System.Windows.Forms.Label lblNewPName;
        private System.Windows.Forms.Label lblNewRow;
    }
}