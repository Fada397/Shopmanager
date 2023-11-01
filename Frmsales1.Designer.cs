namespace shopmanager
{
    partial class Frmsales1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblstockqty = new System.Windows.Forms.Label();
            this.cbxitems = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblunitprice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxqty = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvsales = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnpay = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltotsalesprice = new System.Windows.Forms.Label();
            this.lbtndelete = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvsales)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.cbxitems);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxqty);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Location = new System.Drawing.Point(0, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1262, 223);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblstockqty);
            this.groupBox4.Location = new System.Drawing.Point(1115, 56);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(141, 81);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Stock quantity";
            // 
            // lblstockqty
            // 
            this.lblstockqty.AutoSize = true;
            this.lblstockqty.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblstockqty.Location = new System.Drawing.Point(29, 31);
            this.lblstockqty.Name = "lblstockqty";
            this.lblstockqty.Size = new System.Drawing.Size(19, 23);
            this.lblstockqty.TabIndex = 6;
            this.lblstockqty.Text = "0";
            // 
            // cbxitems
            // 
            this.cbxitems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxitems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbxitems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxitems.FormattingEnabled = true;
            this.cbxitems.Location = new System.Drawing.Point(223, 83);
            this.cbxitems.Name = "cbxitems";
            this.cbxitems.Size = new System.Drawing.Size(368, 36);
            this.cbxitems.TabIndex = 7;
            this.cbxitems.SelectedIndexChanged += new System.EventHandler(this.cbxitems_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblunitprice);
            this.groupBox3.Location = new System.Drawing.Point(964, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(142, 81);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Unit Price (GHc)";
            // 
            // lblunitprice
            // 
            this.lblunitprice.AutoSize = true;
            this.lblunitprice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblunitprice.Location = new System.Drawing.Point(37, 32);
            this.lblunitprice.Name = "lblunitprice";
            this.lblunitprice.Size = new System.Drawing.Size(19, 23);
            this.lblunitprice.TabIndex = 3;
            this.lblunitprice.Text = "0";
            this.lblunitprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(700, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(367, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item";
            // 
            // tbxqty
            // 
            this.tbxqty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxqty.Location = new System.Drawing.Point(649, 83);
            this.tbxqty.Name = "tbxqty";
            this.tbxqty.Size = new System.Drawing.Size(219, 34);
            this.tbxqty.TabIndex = 0;
            this.tbxqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxqty_KeyPress);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnadd.Location = new System.Drawing.Point(528, 159);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(162, 51);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.lbtndelete);
            this.groupBox2.Controls.Add(this.dtgvsales);
            this.groupBox2.Controls.Add(this.btnpay);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbltotsalesprice);
            this.groupBox2.Location = new System.Drawing.Point(4, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1262, 524);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // dtgvsales
            // 
            this.dtgvsales.AllowUserToAddRows = false;
            this.dtgvsales.AllowUserToDeleteRows = false;
            this.dtgvsales.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvsales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvsales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvsales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.unitprice,
            this.quantity,
            this.totalcost,
            this.stockqty,
            this.profit,
            this.ID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvsales.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvsales.Location = new System.Drawing.Point(8, 26);
            this.dtgvsales.Name = "dtgvsales";
            this.dtgvsales.ReadOnly = true;
            this.dtgvsales.RowHeadersWidth = 51;
            this.dtgvsales.RowTemplate.Height = 29;
            this.dtgvsales.Size = new System.Drawing.Size(1238, 400);
            this.dtgvsales.TabIndex = 11;
            this.dtgvsales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Item
            // 
            this.Item.DataPropertyName = "Item";
            this.Item.HeaderText = "Item";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 385;
            // 
            // unitprice
            // 
            this.unitprice.DataPropertyName = "unitprice";
            this.unitprice.HeaderText = "Unit price";
            this.unitprice.MinimumWidth = 6;
            this.unitprice.Name = "unitprice";
            this.unitprice.ReadOnly = true;
            this.unitprice.Width = 250;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 250;
            // 
            // totalcost
            // 
            this.totalcost.DataPropertyName = "totalcost";
            this.totalcost.HeaderText = "Total Cost";
            this.totalcost.MinimumWidth = 6;
            this.totalcost.Name = "totalcost";
            this.totalcost.ReadOnly = true;
            this.totalcost.Width = 300;
            // 
            // stockqty
            // 
            this.stockqty.DataPropertyName = "stockqty";
            this.stockqty.HeaderText = "stockqty";
            this.stockqty.MinimumWidth = 6;
            this.stockqty.Name = "stockqty";
            this.stockqty.ReadOnly = true;
            this.stockqty.Visible = false;
            this.stockqty.Width = 125;
            // 
            // profit
            // 
            this.profit.DataPropertyName = "profit";
            this.profit.HeaderText = "profit";
            this.profit.MinimumWidth = 6;
            this.profit.Name = "profit";
            this.profit.ReadOnly = true;
            this.profit.Visible = false;
            this.profit.Width = 125;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // btnpay
            // 
            this.btnpay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnpay.Location = new System.Drawing.Point(524, 444);
            this.btnpay.Name = "btnpay";
            this.btnpay.Size = new System.Drawing.Size(162, 51);
            this.btnpay.TabIndex = 10;
            this.btnpay.Text = "Pay";
            this.btnpay.UseVisualStyleBackColor = true;
            this.btnpay.Click += new System.EventHandler(this.btnpay_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(879, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total";
            // 
            // lbltotsalesprice
            // 
            this.lbltotsalesprice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltotsalesprice.Location = new System.Drawing.Point(990, 429);
            this.lbltotsalesprice.Name = "lbltotsalesprice";
            this.lbltotsalesprice.Size = new System.Drawing.Size(233, 73);
            this.lbltotsalesprice.TabIndex = 8;
            this.lbltotsalesprice.Text = "0";
            this.lbltotsalesprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbtndelete
            // 
            this.lbtndelete.AutoSize = true;
            this.lbtndelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbtndelete.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lbtndelete.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lbtndelete.Location = new System.Drawing.Point(8, 457);
            this.lbtndelete.Name = "lbtndelete";
            this.lbtndelete.Size = new System.Drawing.Size(59, 23);
            this.lbtndelete.TabIndex = 15;
            this.lbtndelete.TabStop = true;
            this.lbtndelete.Text = "Delete";
            this.lbtndelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbtndelete_LinkClicked);
            // 
            // Frmsales1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 758);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(1279, 805);
            this.MinimumSize = new System.Drawing.Size(1279, 805);
            this.Name = "Frmsales1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmsales1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvsales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbxitems;
        private GroupBox groupBox3;
        private Label lblunitprice;
        private Label label3;
        private Label label2;
        private TextBox tbxqty;
        private Button btnadd;
        private GroupBox groupBox2;
        private Button btnpay;
        private Label label5;
        private Label lbltotsalesprice;
        private DataGridView dtgvsales;
        private GroupBox groupBox4;
        private Label lblstockqty;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn unitprice;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn totalcost;
        private DataGridViewTextBoxColumn stockqty;
        private DataGridViewTextBoxColumn profit;
        private DataGridViewTextBoxColumn ID;
        private LinkLabel lbtndelete;
    }
}