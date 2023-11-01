namespace shopmanager
{
    partial class Frmstart
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
            this.tbxpassword = new System.Windows.Forms.TextBox();
            this.tbxusername = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxpassword);
            this.groupBox1.Controls.Add(this.tbxusername);
            this.groupBox1.Controls.Add(this.btnlogin);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tbxpassword
            // 
            this.tbxpassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxpassword.Location = new System.Drawing.Point(167, 108);
            this.tbxpassword.Name = "tbxpassword";
            this.tbxpassword.PasswordChar = '*';
            this.tbxpassword.PlaceholderText = "Password";
            this.tbxpassword.Size = new System.Drawing.Size(349, 31);
            this.tbxpassword.TabIndex = 4;
            // 
            // tbxusername
            // 
            this.tbxusername.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxusername.Location = new System.Drawing.Point(167, 45);
            this.tbxusername.Name = "tbxusername";
            this.tbxusername.PlaceholderText = "Username";
            this.tbxusername.Size = new System.Drawing.Size(349, 31);
            this.tbxusername.TabIndex = 3;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(253, 178);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(158, 55);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // Frmstart
            // 
            this.AcceptButton = this.btnlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 279);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(706, 326);
            this.MinimumSize = new System.Drawing.Size(706, 326);
            this.Name = "Frmstart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Frmstart_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnlogin;
        private TextBox tbxpassword;
        private TextBox tbxusername;
    }
}