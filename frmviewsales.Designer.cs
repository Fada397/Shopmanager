namespace shopmanager
{
    partial class frmviewsales
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbtndelete = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltotprofit = new System.Windows.Forms.Label();
            this.dtgvsales = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seldate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Personnel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltotsalesprice = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxpers = new System.Windows.Forms.ComboBox();
            this.Dtmfrom = new System.Windows.Forms.DateTimePicker();
            this.btnsearch = new System.Windows.Forms.Button();
            this.cbxitem = new System.Windows.Forms.ComboBox();
            this.DteTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvsales)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.lbtndelete);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbltotprofit);
            this.groupBox2.Controls.Add(this.dtgvsales);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbltotsalesprice);
            this.groupBox2.Location = new System.Drawing.Point(0, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1681, 564);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel1.Location = new System.Drawing.Point(358, 501);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 23);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Email";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbtndelete
            // 
            this.lbtndelete.AutoSize = true;
            this.lbtndelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbtndelete.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lbtndelete.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lbtndelete.Location = new System.Drawing.Point(3, 501);
            this.lbtndelete.Name = "lbtndelete";
            this.lbtndelete.Size = new System.Drawing.Size(59, 23);
            this.lbtndelete.TabIndex = 14;
            this.lbtndelete.TabStop = true;
            this.lbtndelete.Text = "Delete";
            this.lbtndelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbtndelete_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1179, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Profit";
            // 
            // lbltotprofit
            // 
            this.lbltotprofit.AutoSize = true;
            this.lbltotprofit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltotprofit.Location = new System.Drawing.Point(1320, 502);
            this.lbltotprofit.Name = "lbltotprofit";
            this.lbltotprofit.Size = new System.Drawing.Size(23, 28);
            this.lbltotprofit.TabIndex = 12;
            this.lbltotprofit.Text = "0";
            this.lbltotprofit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.seldate,
            this.profit,
            this.ID,
            this.Personnel});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvsales.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvsales.Location = new System.Drawing.Point(14, 23);
            this.dtgvsales.MinimumSize = new System.Drawing.Size(1458, 400);
            this.dtgvsales.Name = "dtgvsales";
            this.dtgvsales.ReadOnly = true;
            this.dtgvsales.RowHeadersWidth = 51;
            this.dtgvsales.RowTemplate.Height = 29;
            this.dtgvsales.Size = new System.Drawing.Size(1655, 452);
            this.dtgvsales.TabIndex = 11;
            // 
            // Item
            // 
            this.Item.DataPropertyName = "Item";
            this.Item.HeaderText = "Item";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 300;
            // 
            // unitprice
            // 
            this.unitprice.DataPropertyName = "unitprice";
            this.unitprice.HeaderText = "Unit price";
            this.unitprice.MinimumWidth = 6;
            this.unitprice.Name = "unitprice";
            this.unitprice.ReadOnly = true;
            this.unitprice.Width = 200;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 200;
            // 
            // totalcost
            // 
            this.totalcost.DataPropertyName = "totalcost";
            this.totalcost.HeaderText = "Total Cost";
            this.totalcost.MinimumWidth = 6;
            this.totalcost.Name = "totalcost";
            this.totalcost.ReadOnly = true;
            this.totalcost.Width = 250;
            // 
            // seldate
            // 
            this.seldate.DataPropertyName = "seldate";
            this.seldate.HeaderText = "Date";
            this.seldate.MinimumWidth = 6;
            this.seldate.Name = "seldate";
            this.seldate.ReadOnly = true;
            this.seldate.Width = 250;
            // 
            // profit
            // 
            this.profit.DataPropertyName = "profit";
            this.profit.HeaderText = "Profit";
            this.profit.MinimumWidth = 6;
            this.profit.Name = "profit";
            this.profit.ReadOnly = true;
            this.profit.Width = 200;
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
            // Personnel
            // 
            this.Personnel.DataPropertyName = "Personnel";
            this.Personnel.HeaderText = "Personnel";
            this.Personnel.MinimumWidth = 6;
            this.Personnel.Name = "Personnel";
            this.Personnel.ReadOnly = true;
            this.Personnel.Width = 200;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(674, 501);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total";
            // 
            // lbltotsalesprice
            // 
            this.lbltotsalesprice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltotsalesprice.Location = new System.Drawing.Point(778, 478);
            this.lbltotsalesprice.Name = "lbltotsalesprice";
            this.lbltotsalesprice.Size = new System.Drawing.Size(233, 73);
            this.lbltotsalesprice.TabIndex = 8;
            this.lbltotsalesprice.Text = "0";
            this.lbltotsalesprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbxpers);
            this.groupBox1.Controls.Add(this.Dtmfrom);
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.cbxitem);
            this.groupBox1.Controls.Add(this.DteTo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1655, 188);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1369, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Personnel";
            // 
            // cbxpers
            // 
            this.cbxpers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxpers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbxpers.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxpers.FormattingEnabled = true;
            this.cbxpers.Location = new System.Drawing.Point(1235, 69);
            this.cbxpers.Name = "cbxpers";
            this.cbxpers.Size = new System.Drawing.Size(353, 31);
            this.cbxpers.TabIndex = 9;
            // 
            // Dtmfrom
            // 
            this.Dtmfrom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dtmfrom.Location = new System.Drawing.Point(592, 70);
            this.Dtmfrom.Name = "Dtmfrom";
            this.Dtmfrom.Size = new System.Drawing.Size(271, 30);
            this.Dtmfrom.TabIndex = 2;
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsearch.Location = new System.Drawing.Point(829, 130);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(131, 49);
            this.btnsearch.TabIndex = 8;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // cbxitem
            // 
            this.cbxitem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxitem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbxitem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxitem.FormattingEnabled = true;
            this.cbxitem.Location = new System.Drawing.Point(107, 66);
            this.cbxitem.Name = "cbxitem";
            this.cbxitem.Size = new System.Drawing.Size(414, 31);
            this.cbxitem.TabIndex = 0;
            // 
            // DteTo
            // 
            this.DteTo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DteTo.Location = new System.Drawing.Point(919, 70);
            this.DteTo.Name = "DteTo";
            this.DteTo.Size = new System.Drawing.Size(287, 30);
            this.DteTo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1012, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(703, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date From";
            // 
            // frmviewsales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1689, 791);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximumSize = new System.Drawing.Size(1707, 838);
            this.MinimumSize = new System.Drawing.Size(1707, 838);
            this.Name = "frmviewsales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.frmviewsales_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvsales)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dtgvsales;
        private Label label5;
        private Label lbltotsalesprice;
        private GroupBox groupBox1;
        private DateTimePicker Dtmfrom;
        private Button btnsearch;
        private ComboBox cbxitem;
        private DateTimePicker DteTo;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label lbltotprofit;
        private LinkLabel lbtndelete;
        private LinkLabel linkLabel1;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn unitprice;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn totalcost;
        private DataGridViewTextBoxColumn seldate;
        private DataGridViewTextBoxColumn profit;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Personnel;
        private Label label6;
        private ComboBox cbxpers;
    }
}