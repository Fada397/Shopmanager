namespace shopmanager
{
    partial class FrmeditPrice
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
            this.tbxprice = new System.Windows.Forms.TextBox();
            this.lblitemdescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.tbxprice);
            this.groupBox1.Controls.Add(this.lblitemdescription);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tbxprice
            // 
            this.tbxprice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxprice.Location = new System.Drawing.Point(153, 95);
            this.tbxprice.Name = "tbxprice";
            this.tbxprice.Size = new System.Drawing.Size(270, 30);
            this.tbxprice.TabIndex = 3;
            this.tbxprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxprice_KeyPress_1);
            // 
            // lblitemdescription
            // 
            this.lblitemdescription.AutoSize = true;
            this.lblitemdescription.Location = new System.Drawing.Point(153, 35);
            this.lblitemdescription.Name = "lblitemdescription";
            this.lblitemdescription.Size = new System.Drawing.Size(39, 20);
            this.lblitemdescription.TabIndex = 2;
            this.lblitemdescription.Text = "Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Update Price";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(251, 177);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(127, 59);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // FrmeditPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 294);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(685, 341);
            this.MinimumSize = new System.Drawing.Size(685, 341);
            this.Name = "FrmeditPrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Price";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnsave;
        private TextBox tbxprice;
        private Label lblitemdescription;
        private Label label1;
    }
}