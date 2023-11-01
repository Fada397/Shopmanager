namespace shopmanager
{
    partial class frmMain
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
            this.btnsell = new System.Windows.Forms.Button();
            this.lnkstock = new System.Windows.Forms.LinkLabel();
            this.lnkprices = new System.Windows.Forms.LinkLabel();
            this.lnksales = new System.Windows.Forms.LinkLabel();
            this.lnkpersonell = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblpersonnelname = new System.Windows.Forms.Label();
            this.lnkbackup = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsell
            // 
            this.btnsell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsell.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsell.Location = new System.Drawing.Point(196, 84);
            this.btnsell.Name = "btnsell";
            this.btnsell.Size = new System.Drawing.Size(223, 73);
            this.btnsell.TabIndex = 1;
            this.btnsell.Text = "Sell Now";
            this.btnsell.UseVisualStyleBackColor = true;
            this.btnsell.Click += new System.EventHandler(this.btnsell_Click);
            // 
            // lnkstock
            // 
            this.lnkstock.AutoSize = true;
            this.lnkstock.BackColor = System.Drawing.Color.Transparent;
            this.lnkstock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnkstock.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkstock.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lnkstock.Location = new System.Drawing.Point(12, 9);
            this.lnkstock.Name = "lnkstock";
            this.lnkstock.Size = new System.Drawing.Size(60, 28);
            this.lnkstock.TabIndex = 8;
            this.lnkstock.TabStop = true;
            this.lnkstock.Text = "Stock";
            this.lnkstock.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkstock_LinkClicked);
            // 
            // lnkprices
            // 
            this.lnkprices.AutoSize = true;
            this.lnkprices.BackColor = System.Drawing.Color.Transparent;
            this.lnkprices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnkprices.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkprices.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lnkprices.Location = new System.Drawing.Point(118, 9);
            this.lnkprices.Name = "lnkprices";
            this.lnkprices.Size = new System.Drawing.Size(62, 28);
            this.lnkprices.TabIndex = 9;
            this.lnkprices.TabStop = true;
            this.lnkprices.Text = "Prices";
            this.lnkprices.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkprices_LinkClicked);
            // 
            // lnksales
            // 
            this.lnksales.AutoSize = true;
            this.lnksales.BackColor = System.Drawing.Color.Transparent;
            this.lnksales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnksales.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnksales.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lnksales.Location = new System.Drawing.Point(229, 9);
            this.lnksales.Name = "lnksales";
            this.lnksales.Size = new System.Drawing.Size(56, 28);
            this.lnksales.TabIndex = 10;
            this.lnksales.TabStop = true;
            this.lnksales.Text = "Sales";
            this.lnksales.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnksales_LinkClicked);
            // 
            // lnkpersonell
            // 
            this.lnkpersonell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkpersonell.AutoSize = true;
            this.lnkpersonell.BackColor = System.Drawing.Color.Transparent;
            this.lnkpersonell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnkpersonell.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkpersonell.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lnkpersonell.Location = new System.Drawing.Point(883, 9);
            this.lnkpersonell.Name = "lnkpersonell";
            this.lnkpersonell.Size = new System.Drawing.Size(172, 28);
            this.lnkpersonell.TabIndex = 11;
            this.lnkpersonell.TabStop = true;
            this.lnkpersonell.Text = "Manage Personnel";
            this.lnkpersonell.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkpersonell_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnsell);
            this.groupBox1.Location = new System.Drawing.Point(359, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 245);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // lblpersonnelname
            // 
            this.lblpersonnelname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblpersonnelname.AutoSize = true;
            this.lblpersonnelname.Location = new System.Drawing.Point(6, 726);
            this.lblpersonnelname.Name = "lblpersonnelname";
            this.lblpersonnelname.Size = new System.Drawing.Size(74, 20);
            this.lblpersonnelname.TabIndex = 13;
            this.lblpersonnelname.Text = "personnel";
            // 
            // lnkbackup
            // 
            this.lnkbackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkbackup.AutoSize = true;
            this.lnkbackup.BackColor = System.Drawing.Color.Transparent;
            this.lnkbackup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnkbackup.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkbackup.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lnkbackup.Location = new System.Drawing.Point(1107, 9);
            this.lnkbackup.Name = "lnkbackup";
            this.lnkbackup.Size = new System.Drawing.Size(163, 28);
            this.lnkbackup.TabIndex = 14;
            this.lnkbackup.TabStop = true;
            this.lnkbackup.Text = "Back up / Restore";
            this.lnkbackup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkbackup_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 752);
            this.Controls.Add(this.lnkbackup);
            this.Controls.Add(this.lblpersonnelname);
            this.Controls.Add(this.lnksales);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lnkstock);
            this.Controls.Add(this.lnkpersonell);
            this.Controls.Add(this.lnkprices);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop Manager";
            this.Load += new System.EventHandler(this.Frmstart_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnsell;
        private LinkLabel lnkstock;
        private LinkLabel lnkprices;
        private LinkLabel lnksales;
        private LinkLabel lnkpersonell;
        private GroupBox groupBox1;
        private Label lblpersonnelname;
        private LinkLabel lnkbackup;
    }
}