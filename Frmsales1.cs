using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopmanager
{
    public partial class Frmsales1 : Form
    {
        public Frmsales1()
        {
            InitializeComponent();
            allreg();
            autocomplete();
            
        }



     




        DataTable dtreg = new DataTable();
        DataTable dtreg1 = new DataTable();
        string pers = Frmstart.usernam;
        private void allreg()
        {

            ClsRegister allregister = new ClsRegister();
            allregister.selectregister();
            dtreg = allregister.dtregister.Copy();
            dtreg1 = allregister.dtregister.Copy();

            //convert item row to array
            string[] postSource = dtreg1
                   .AsEnumerable()
                   .Select<System.Data.DataRow, String>(x => x.Field<String>("Item"))
                   .ToArray();

            cbxitems.Items.AddRange(postSource);
            cbxitems.SelectedIndex = -1;

            //Note combobox(cbxitem) can only be set to selected index -1 if not databinded thereby adding data by addrang , array
        }


        private void autocomplete()
        {
            string[] postSource = dtreg1
                    .AsEnumerable()
                    .Select<System.Data.DataRow, String>(x => x.Field<String>("Item"))
                    .ToArray();

            var source = new AutoCompleteStringCollection();
            source.AddRange(postSource);
            cbxitems.AutoCompleteCustomSource = source;

            //textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }



        //.specific item//
        DataTable filterreg = new DataTable();
        string stockqty1;
        string costprice1;
        public void filter_specificitems()
        {
            if (dtreg.Rows.Count > 0)
            {
                string itm = this.cbxitems.GetItemText(cbxitems.SelectedItem);
                DataView filter = new DataView(dtreg1);
                filter.RowFilter = "item = '" + itm + "'";
                filterreg = filter.ToTable();



                stockqty1 = filterreg.Rows[0]["Stockqty"].ToString();  //get quantity at stock


                lblunitprice.Text = filterreg.Rows[0]["Price"].ToString();
                lblstockqty.Text = stockqty1;
                costprice1 = filterreg.Rows[0]["Costprice"].ToString();

            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        DataTable dtsales = new DataTable();
        private void btnadd_Click(object sender, EventArgs e)
        {

            try
            {
                decimal stqty, selqty, profit1;
            stqty = decimal.Parse(stockqty1);
            selqty = decimal.Parse(tbxqty.Text .Trim());

            if (cbxitems.SelectedIndex > -1 && stqty >= selqty)
            {
                //Use stockqty from filter_specificitems() method, stockqty is greater than or equal to entered qty ...continue sales
                //if (int.Parse(stockqty) >= int.Parse(tbxqty.Text.Trim()))
                //{

                    if (dtsales.Columns.Count == 0)
                    {

                         //DataColumn ID = new DataColumn("ID", typeof(string));
                        DataColumn item = new DataColumn("item", typeof(string));
                        DataColumn unitprice = new DataColumn("unitprice", typeof(string));
                        DataColumn quantity = new DataColumn("quantity", typeof(string));
                        DataColumn totalcost = new DataColumn("totalcost", typeof(Decimal));
                        DataColumn stockqty = new DataColumn("stockqty", typeof(Decimal));
                        DataColumn profit = new DataColumn("profit", typeof(Decimal));
                        DataColumn pson = new DataColumn("personnel", typeof(string));

                        //dtsales.Columns.Add(ID);
                        dtsales.Columns.Add(item);
                        dtsales.Columns.Add(unitprice);
                        dtsales.Columns.Add(quantity);
                        dtsales.Columns.Add(totalcost);
                        dtsales.Columns.Add(stockqty);
                        dtsales.Columns.Add(profit);
                        dtsales.Columns.Add(pson);
                    }

                    // search if item not added already
                    string itm = this.cbxitems.GetItemText(cbxitems.SelectedItem);
                      //filter datatable
                    DataRow[] row = dtsales.Select("item ='" + itm + "'");
                    int count = row.Count();

                    //int count = 0;
                    if (count == 0)
                    {



                        DataRow dr = dtsales.NewRow();
                        dr["item"] = itm;
                        dr["unitprice"] = lblunitprice.Text;
                        dr["quantity"] = (Int32.Parse(tbxqty.Text.Trim())).ToString();

                        decimal totsellingprice = Int32.Parse(tbxqty.Text.Trim()) * decimal.Parse(lblunitprice.Text);
                        dr["totalcost"] = totsellingprice.ToString();
                        dr["stockqty"] = Decimal.Parse(stockqty1);

                        decimal totcostprice = Int32.Parse(tbxqty.Text.Trim()) * decimal.Parse(costprice1);
                        profit1 = totsellingprice - totcostprice;
                        dr["profit"] = profit1;

                        dr["personnel"] = pers;

                        dtsales.Rows.Add(dr);  // add row to datatable

                        //
                        dtgvsales.AutoGenerateColumns = false;
                        //dtgvsales.Rows.Add(dr);
                        dtgvsales.DataSource = dtsales;

                        // var totprice = filterdtble.AsEnumerable()
                        //.Sum(x => Convert.ToInt32(x["totalcost"]));   //use this LINQ if column is of type string


                        decimal totprice = Convert.ToDecimal(dtsales.Compute("SUM(totalcost)", string.Empty));
                        lbltotsalesprice.Text = totprice.ToString();


                        cbxitems.SelectedIndex = -1;
                        tbxqty.Clear();






                    }
                    else
                    {
                        MessageBox.Show("Item already added");
                    }
              //}
                //else { MessageBox.Show("Quantity at stock not enough"); }
            }
            else if (selqty>stqty)

                { MessageBox.Show("Quantity at stock not enough"); }



            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void stockcontrol( string item1,string stockqty1,string selqty1)
        {

         decimal newstockqty = decimal.Parse(stockqty1) - decimal.Parse(selqty1);

            //filter datatable
            DataRow[] row = dtreg.Select("Item ='" + item1 + "'");
            DataRow row1 = row[0]; //get unique row from the array
            int index = dtreg.Rows.IndexOf(row1); //get index of datatable

            dtreg.Rows[index]["Stockqty"] = newstockqty;


            DataTable dats = new DataTable();
            dats = dtreg.Copy();

            dats.TableName = "reg";
            dats.WriteXml("ItemRegister.xml");



            dtreg1 = dtreg.Copy();
        }


        private void btnpay_Click(object sender, EventArgs e)
        {
            try
            {
                string itm, sellqty, s_cost, up,stockquantity,date1,profit;
                date1 = DateTime.Now.ToString("MMM. dd, yyyy");
                ClsSales inssales = new ClsSales();
                if (dtsales.Rows.Count > 0)
                {

                    foreach (DataRow rw in dtsales.Rows)
                    {
                        itm = rw["item"].ToString();
                        sellqty = rw["quantity"].ToString();
                        s_cost = rw["totalcost"].ToString();
                        up = rw["unitprice"].ToString();
                        stockquantity = rw["stockqty"].ToString();
                       profit = rw["profit"].ToString();

                        inssales.Salesinsert(itm, sellqty, up, s_cost,date1,profit,pers);

                        stockcontrol(itm, stockquantity, sellqty);

                        //subtract quantity from stock
                    }

                    dtsales.Rows.Clear();
                    lbltotsalesprice.Text = "0";
                    cbxitems.SelectedIndex=-1;


                    dtgvsales.AutoGenerateColumns = false;
                     dtgvsales.DataSource = dtsales;



                    MessageBox.Show("Saved");





                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void cbxitems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxitems.SelectedIndex > -1)
            {
                filter_specificitems();
            }
            else { lblunitprice.Text = "0";lblstockqty.Text = "0"; }
        }

        private void tbxqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void lbtndelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            if (dtgvsales.CurrentCell != null)
            {



                   
    int ind = dtgvsales.CurrentRow.Index;

                    dtsales.Rows.RemoveAt(ind);

                    DataTable dats = new DataTable();
                    dats = dtsales.Copy();



                    dtgvsales.AutoGenerateColumns = false;
                    dtgvsales.DataSource = dats;



                    //int rowind = dtgvstock .CurrentRow .Index;
                    //dtgvstock.Rows.RemoveAt(rowind);





                


            }

        }
    }
}
