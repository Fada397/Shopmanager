namespace shopmanager
{
    partial class Backup
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
            this.lnlrestore = new System.Windows.Forms.LinkLabel();
            this.Btnbackup = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxselcttfolder = new System.Windows.Forms.TextBox();
            this.btnselectfolder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnlrestore
            // 
            this.lnlrestore.AutoSize = true;
            this.lnlrestore.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnlrestore.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.lnlrestore.Location = new System.Drawing.Point(608, 225);
            this.lnlrestore.Name = "lnlrestore";
            this.lnlrestore.Size = new System.Drawing.Size(59, 20);
            this.lnlrestore.TabIndex = 10;
            this.lnlrestore.TabStop = true;
            this.lnlrestore.Text = "Restore";
            this.lnlrestore.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnlrestore_LinkClicked);
            // 
            // Btnbackup
            // 
            this.Btnbackup.Location = new System.Drawing.Point(322, 212);
            this.Btnbackup.Name = "Btnbackup";
            this.Btnbackup.Size = new System.Drawing.Size(173, 47);
            this.Btnbackup.TabIndex = 9;
            this.Btnbackup.Text = "Back Up";
            this.Btnbackup.UseVisualStyleBackColor = true;
            this.Btnbackup.Click += new System.EventHandler(this.Btnbackup_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxselcttfolder);
            this.groupBox1.Controls.Add(this.btnselectfolder);
            this.groupBox1.Location = new System.Drawing.Point(39, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 178);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // tbxselcttfolder
            // 
            this.tbxselcttfolder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxselcttfolder.Location = new System.Drawing.Point(192, 52);
            this.tbxselcttfolder.Name = "tbxselcttfolder";
            this.tbxselcttfolder.ReadOnly = true;
            this.tbxselcttfolder.Size = new System.Drawing.Size(386, 27);
            this.tbxselcttfolder.TabIndex = 1;
            // 
            // btnselectfolder
            // 
            this.btnselectfolder.Location = new System.Drawing.Point(295, 125);
            this.btnselectfolder.Name = "btnselectfolder";
            this.btnselectfolder.Size = new System.Drawing.Size(173, 29);
            this.btnselectfolder.TabIndex = 0;
            this.btnselectfolder.Text = "Select folder";
            this.btnselectfolder.UseVisualStyleBackColor = true;
            this.btnselectfolder.Click += new System.EventHandler(this.btnselectfolder_Click);
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 279);
            this.Controls.Add(this.lnlrestore);
            this.Controls.Add(this.Btnbackup);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(835, 326);
            this.MinimumSize = new System.Drawing.Size(835, 326);
            this.Name = "Backup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel lnlrestore;
        private Button Btnbackup;
        private GroupBox groupBox1;
        private TextBox tbxselcttfolder;
        private Button btnselectfolder;
    }
}