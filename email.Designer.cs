namespace shopmanager
{
    partial class email
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
            this.btnemail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnemail
            // 
            this.btnemail.Location = new System.Drawing.Point(367, 288);
            this.btnemail.Name = "btnemail";
            this.btnemail.Size = new System.Drawing.Size(94, 29);
            this.btnemail.TabIndex = 0;
            this.btnemail.Text = "Send Email";
            this.btnemail.UseVisualStyleBackColor = true;
            this.btnemail.Click += new System.EventHandler(this.btnemail_Click);
            // 
            // email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnemail);
            this.Name = "email";
            this.Text = "email";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnemail;
    }
}