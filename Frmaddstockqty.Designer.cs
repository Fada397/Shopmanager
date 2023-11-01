namespace shopmanager
{
    partial class Frmaddstockqty
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
            this.tbxqty = new System.Windows.Forms.TextBox();
            this.lblitemdescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.qtystock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.qtystock);
            this.groupBox1.Controls.Add(this.tbxqty);
            this.groupBox1.Controls.Add(this.lblitemdescription);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 271);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // tbxqty
            // 
            this.tbxqty.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxqty.Location = new System.Drawing.Point(210, 119);
            this.tbxqty.Name = "tbxqty";
            this.tbxqty.Size = new System.Drawing.Size(270, 30);
            this.tbxqty.TabIndex = 3;
            this.tbxqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxqty_KeyPress);
            // 
            // lblitemdescription
            // 
            this.lblitemdescription.AutoSize = true;
            this.lblitemdescription.Location = new System.Drawing.Point(210, 33);
            this.lblitemdescription.Name = "lblitemdescription";
            this.lblitemdescription.Size = new System.Drawing.Size(39, 20);
            this.lblitemdescription.TabIndex = 2;
            this.lblitemdescription.Text = "Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New Stock";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(285, 171);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(127, 59);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // qtystock
            // 
            this.qtystock.AutoSize = true;
            this.qtystock.Location = new System.Drawing.Point(210, 85);
            this.qtystock.Name = "qtystock";
            this.qtystock.Size = new System.Drawing.Size(30, 20);
            this.qtystock.TabIndex = 4;
            this.qtystock.Text = "qty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Qty At Stock";
            // 
            // Frmaddstockqty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 296);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(689, 343);
            this.MinimumSize = new System.Drawing.Size(689, 343);
            this.Name = "Frmaddstockqty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Stock";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbxqty;
        private Label lblitemdescription;
        private Label label1;
        private Button btnsave;
        private Label label3;
        private Label qtystock;
    }
}