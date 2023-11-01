namespace shopmanager
{
    partial class FrmRegister
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
            this.tbxstockqty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxcostprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxprice = new System.Windows.Forms.TextBox();
            this.tbxdescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsaveregister = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.tbxstockqty);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxcostprice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxprice);
            this.groupBox1.Controls.Add(this.tbxdescription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnsaveregister);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(979, 486);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tbxstockqty
            // 
            this.tbxstockqty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxstockqty.Location = new System.Drawing.Point(248, 284);
            this.tbxstockqty.Name = "tbxstockqty";
            this.tbxstockqty.Size = new System.Drawing.Size(255, 34);
            this.tbxstockqty.TabIndex = 8;
            this.tbxstockqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxstockqty_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stock quantity";
            // 
            // tbxcostprice
            // 
            this.tbxcostprice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxcostprice.Location = new System.Drawing.Point(248, 149);
            this.tbxcostprice.Name = "tbxcostprice";
            this.tbxcostprice.Size = new System.Drawing.Size(255, 34);
            this.tbxcostprice.TabIndex = 6;
            this.tbxcostprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxcostprice_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cost Price";
            // 
            // tbxprice
            // 
            this.tbxprice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxprice.Location = new System.Drawing.Point(251, 212);
            this.tbxprice.Name = "tbxprice";
            this.tbxprice.Size = new System.Drawing.Size(255, 34);
            this.tbxprice.TabIndex = 4;
            this.tbxprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxprice_KeyPress);
            // 
            // tbxdescription
            // 
            this.tbxdescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxdescription.Location = new System.Drawing.Point(251, 79);
            this.tbxdescription.Name = "tbxdescription";
            this.tbxdescription.Size = new System.Drawing.Size(512, 34);
            this.tbxdescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "selling Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Description";
            // 
            // btnsaveregister
            // 
            this.btnsaveregister.Location = new System.Drawing.Point(413, 367);
            this.btnsaveregister.Name = "btnsaveregister";
            this.btnsaveregister.Size = new System.Drawing.Size(151, 60);
            this.btnsaveregister.TabIndex = 0;
            this.btnsaveregister.Text = "Save";
            this.btnsaveregister.UseVisualStyleBackColor = true;
            this.btnsaveregister.Click += new System.EventHandler(this.btnsaveregister_Click);
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 502);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1021, 549);
            this.MinimumSize = new System.Drawing.Size(1021, 549);
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Register";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnsaveregister;
        private TextBox tbxprice;
        private TextBox tbxdescription;
        private Label label2;
        private TextBox tbxcostprice;
        private Label label3;
        private TextBox tbxstockqty;
        private Label label4;
    }
}