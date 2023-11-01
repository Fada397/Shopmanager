namespace shopmanager
{
    partial class ViewStock
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
            this.dtgvstock = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stockqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbtndelete = new System.Windows.Forms.LinkLabel();
            this.lbtnedtprice = new System.Windows.Forms.LinkLabel();
            this.lbtnedtstockqty = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.Cbxitems = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvstock)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvstock
            // 
            this.dtgvstock.AllowUserToAddRows = false;
            this.dtgvstock.AllowUserToDeleteRows = false;
            this.dtgvstock.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvstock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvstock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Stockqty,
            this.Price,
            this.Costprice,
            this.ID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvstock.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvstock.Location = new System.Drawing.Point(67, 158);
            this.dtgvstock.Name = "dtgvstock";
            this.dtgvstock.RowHeadersWidth = 51;
            this.dtgvstock.RowTemplate.Height = 29;
            this.dtgvstock.Size = new System.Drawing.Size(879, 498);
            this.dtgvstock.TabIndex = 0;
            this.dtgvstock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvstock_CellContentClick);
            // 
            // Item
            // 
            this.Item.DataPropertyName = "Item";
            this.Item.HeaderText = "Description";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            this.Item.Width = 300;
            // 
            // Stockqty
            // 
            this.Stockqty.DataPropertyName = "Stockqty";
            this.Stockqty.HeaderText = "Quantity";
            this.Stockqty.MinimumWidth = 6;
            this.Stockqty.Name = "Stockqty";
            this.Stockqty.Width = 200;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Selling Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 200;
            // 
            // Costprice
            // 
            this.Costprice.DataPropertyName = "Costprice";
            this.Costprice.HeaderText = "Cost price";
            this.Costprice.MinimumWidth = 6;
            this.Costprice.Name = "Costprice";
            this.Costprice.Width = 125;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.lbtndelete);
            this.groupBox1.Controls.Add(this.lbtnedtprice);
            this.groupBox1.Controls.Add(this.lbtnedtstockqty);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Cbxitems);
            this.groupBox1.Controls.Add(this.dtgvstock);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1016, 726);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel2.Location = new System.Drawing.Point(44, 677);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(111, 23);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Register Item";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel1.Location = new System.Drawing.Point(315, 677);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(144, 23);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add Stock quatity";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbtndelete
            // 
            this.lbtndelete.AutoSize = true;
            this.lbtndelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbtndelete.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lbtndelete.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lbtndelete.Location = new System.Drawing.Point(937, 677);
            this.lbtndelete.Name = "lbtndelete";
            this.lbtndelete.Size = new System.Drawing.Size(59, 23);
            this.lbtndelete.TabIndex = 6;
            this.lbtndelete.TabStop = true;
            this.lbtndelete.Text = "Delete";
            this.lbtndelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbtndelete_LinkClicked);
            // 
            // lbtnedtprice
            // 
            this.lbtnedtprice.AutoSize = true;
            this.lbtnedtprice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbtnedtprice.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lbtnedtprice.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lbtnedtprice.Location = new System.Drawing.Point(764, 677);
            this.lbtnedtprice.Name = "lbtnedtprice";
            this.lbtnedtprice.Size = new System.Drawing.Size(111, 23);
            this.lbtnedtprice.TabIndex = 5;
            this.lbtnedtprice.TabStop = true;
            this.lbtnedtprice.Text = "Change Price";
            this.lbtnedtprice.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbtnedtprice_LinkClicked);
            // 
            // lbtnedtstockqty
            // 
            this.lbtnedtstockqty.AutoSize = true;
            this.lbtnedtstockqty.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbtnedtstockqty.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lbtnedtstockqty.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lbtnedtstockqty.Location = new System.Drawing.Point(521, 677);
            this.lbtnedtstockqty.Name = "lbtnedtstockqty";
            this.lbtnedtstockqty.Size = new System.Drawing.Size(185, 23);
            this.lbtnedtstockqty.TabIndex = 4;
            this.lbtnedtstockqty.TabStop = true;
            this.lbtnedtstockqty.Text = "Change Stock Quantity";
            this.lbtnedtstockqty.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbtnedtstockqty_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item";
            // 
            // Cbxitems
            // 
            this.Cbxitems.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cbxitems.FormattingEnabled = true;
            this.Cbxitems.Location = new System.Drawing.Point(342, 46);
            this.Cbxitems.Name = "Cbxitems";
            this.Cbxitems.Size = new System.Drawing.Size(354, 33);
            this.Cbxitems.TabIndex = 1;
            this.Cbxitems.SelectedIndexChanged += new System.EventHandler(this.Cbxitems_SelectedIndexChanged);
            // 
            // ViewStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 743);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1058, 790);
            this.MinimumSize = new System.Drawing.Size(1058, 790);
            this.Name = "ViewStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Stock";
            this.Load += new System.EventHandler(this.ViewStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvstock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dtgvstock;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox Cbxitems;
        private LinkLabel lbtnedtprice;
        private LinkLabel lbtnedtstockqty;
        private LinkLabel lbtndelete;
        private LinkLabel linkLabel1;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn Stockqty;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Costprice;
        private DataGridViewTextBoxColumn ID;
        private LinkLabel linkLabel2;
    }
}