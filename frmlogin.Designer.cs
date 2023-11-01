namespace shopmanager
{
    partial class frmlogin
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
            this.lbtndelete = new System.Windows.Forms.LinkLabel();
            this.tbxconfirmpassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxprivilege = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxusername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxpasword = new System.Windows.Forms.TextBox();
            this.tbxname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.lbtndelete);
            this.groupBox1.Controls.Add(this.tbxconfirmpassword);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbxprivilege);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxusername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxpasword);
            this.groupBox1.Controls.Add(this.tbxname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(979, 538);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lbtndelete
            // 
            this.lbtndelete.AutoSize = true;
            this.lbtndelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbtndelete.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lbtndelete.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lbtndelete.Location = new System.Drawing.Point(854, 464);
            this.lbtndelete.Name = "lbtndelete";
            this.lbtndelete.Size = new System.Drawing.Size(39, 23);
            this.lbtndelete.TabIndex = 8;
            this.lbtndelete.TabStop = true;
            this.lbtndelete.Text = "Edit";
            this.lbtndelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbtndelete_LinkClicked);
            // 
            // tbxconfirmpassword
            // 
            this.tbxconfirmpassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxconfirmpassword.Location = new System.Drawing.Point(251, 288);
            this.tbxconfirmpassword.Name = "tbxconfirmpassword";
            this.tbxconfirmpassword.PasswordChar = '*';
            this.tbxconfirmpassword.Size = new System.Drawing.Size(457, 34);
            this.tbxconfirmpassword.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Confirm Password";
            // 
            // cbxprivilege
            // 
            this.cbxprivilege.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxprivilege.FormattingEnabled = true;
            this.cbxprivilege.Items.AddRange(new object[] {
            "Admin",
            "Salesperson"});
            this.cbxprivilege.Location = new System.Drawing.Point(251, 362);
            this.cbxprivilege.Name = "cbxprivilege";
            this.cbxprivilege.Size = new System.Drawing.Size(384, 33);
            this.cbxprivilege.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Previlege";
            // 
            // tbxusername
            // 
            this.tbxusername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxusername.Location = new System.Drawing.Point(248, 149);
            this.tbxusername.Name = "tbxusername";
            this.tbxusername.Size = new System.Drawing.Size(457, 34);
            this.tbxusername.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username";
            // 
            // tbxpasword
            // 
            this.tbxpasword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxpasword.Location = new System.Drawing.Point(248, 217);
            this.tbxpasword.Name = "tbxpasword";
            this.tbxpasword.PasswordChar = '*';
            this.tbxpasword.Size = new System.Drawing.Size(457, 34);
            this.tbxpasword.TabIndex = 4;
            // 
            // tbxname
            // 
            this.tbxname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxname.Location = new System.Drawing.Point(251, 79);
            this.tbxname.Name = "tbxname";
            this.tbxname.Size = new System.Drawing.Size(512, 34);
            this.tbxname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(412, 446);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(151, 60);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 541);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(986, 588);
            this.MinimumSize = new System.Drawing.Size(986, 588);
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add  Personnel";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private TextBox tbxusername;
        private Label label3;
        private TextBox tbxpasword;
        private TextBox tbxname;
        private Label label2;
        private Label label1;
        private Button btnsave;
        private ComboBox cbxprivilege;
        private TextBox tbxconfirmpassword;
        private Label label5;
        private LinkLabel lbtndelete;
    }
}