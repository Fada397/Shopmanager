namespace shopmanager
{
    partial class frmeditlogin
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
            this.cbxusername = new System.Windows.Forms.ComboBox();
            this.lbtndelete = new System.Windows.Forms.LinkLabel();
            this.tbxname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxpasword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.cbxusername);
            this.groupBox1.Controls.Add(this.lbtndelete);
            this.groupBox1.Controls.Add(this.tbxname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxpasword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Location = new System.Drawing.Point(-4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(979, 408);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // cbxusername
            // 
            this.cbxusername.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxusername.FormattingEnabled = true;
            this.cbxusername.Location = new System.Drawing.Point(251, 82);
            this.cbxusername.Name = "cbxusername";
            this.cbxusername.Size = new System.Drawing.Size(384, 33);
            this.cbxusername.TabIndex = 9;
            this.cbxusername.SelectedIndexChanged += new System.EventHandler(this.cbxusername_SelectedIndexChanged);
            // 
            // lbtndelete
            // 
            this.lbtndelete.AutoSize = true;
            this.lbtndelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbtndelete.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lbtndelete.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lbtndelete.Location = new System.Drawing.Point(872, 333);
            this.lbtndelete.Name = "lbtndelete";
            this.lbtndelete.Size = new System.Drawing.Size(59, 23);
            this.lbtndelete.TabIndex = 7;
            this.lbtndelete.TabStop = true;
            this.lbtndelete.Text = "Delete";
            this.lbtndelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbtndelete_LinkClicked);
            // 
            // tbxname
            // 
            this.tbxname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxname.Location = new System.Drawing.Point(248, 149);
            this.tbxname.Name = "tbxname";
            this.tbxname.Size = new System.Drawing.Size(440, 34);
            this.tbxname.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username";
            // 
            // tbxpasword
            // 
            this.tbxpasword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxpasword.Location = new System.Drawing.Point(251, 212);
            this.tbxpasword.Name = "tbxpasword";
            this.tbxpasword.Size = new System.Drawing.Size(384, 34);
            this.tbxpasword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(375, 296);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(151, 60);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // frmeditlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 413);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(997, 460);
            this.MinimumSize = new System.Drawing.Size(997, 460);
            this.Name = "frmeditlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Personnel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbxname;
        private Label label3;
        private TextBox tbxpasword;
        private Label label2;
        private Label label1;
        private Button btnsave;
        private LinkLabel lbtndelete;
        private ComboBox cbxusername;
    }
}