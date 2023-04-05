
namespace Text_Adventure_Project
{
    partial class StartingPrompt
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
            this.Submit = new System.Windows.Forms.Button();
            this.StartingText = new System.Windows.Forms.Label();
            this.NameChoosing = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(154, 253);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Next";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // StartingText
            // 
            this.StartingText.AutoSize = true;
            this.StartingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartingText.Location = new System.Drawing.Point(12, 9);
            this.StartingText.Name = "StartingText";
            this.StartingText.Size = new System.Drawing.Size(0, 39);
            this.StartingText.TabIndex = 0;
            // 
            // NameChoosing
            // 
            this.NameChoosing.Location = new System.Drawing.Point(65, 213);
            this.NameChoosing.Name = "NameChoosing";
            this.NameChoosing.Size = new System.Drawing.Size(279, 20);
            this.NameChoosing.TabIndex = 1;
            // 
            // StartingPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 305);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.NameChoosing);
            this.Controls.Add(this.StartingText);
            this.Name = "StartingPrompt";
            this.Text = "Welcome!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label StartingText;
        private System.Windows.Forms.TextBox NameChoosing;
    }
}

