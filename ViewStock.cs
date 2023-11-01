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
    public partial class ViewStock : Form
    {
        public ViewStock()
        {
            InitializeComponent();
            allreg();

            allitems();
        }

        private void lbtnallitems_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }



        public void indexchange()
        {
            if (Cbxitems.SelectedIndex == 0) { allitems(); }
            else
            { filter_specificitems(); }
        }
        private void Cbxitems_SelectedIndexChanged(object sender, EventArgs e)
        {
           indexchange(); 
        }



        DataTable dtreg = new DataTable();
        DataTable dtreg1 = new DataTable();
        public void allreg()
        {
            ClsRegister allregister = new ClsRegister();
            allregister.selectregister();
            dtreg = allregister.dtregister.Copy();
            dtreg1 = allregister.dtregister.Copy();

            if (dtreg1.Rows.Count>0)
            {
                DataRow dtrow = dtreg1.NewRow();
                dtrow["item"] = "All";
                dtreg1.Rows.InsertAt(dtrow, 0);
            }



            if (dtreg1.Rows.Count != 0)
            {
                this.Cbxitems.DataSource = dtreg1;
                this.Cbxitems.DisplayMember = "item";
                this.Cbxitems.ValueMember = "ID";
            }

        }


         public void allitems()
        {
             dtgvstock.AutoGenerateColumns = false;
            dtgvstock.DataSource = dtreg;

        }



        //filter sales ....specific item//
        DataTable filterreg = new DataTable();
        public void filter_specificitems()
        {
            string itm = this.Cbxitems.GetItemText(Cbxitems.SelectedItem);
            DataView filter = new DataView(dtreg);
            filter.RowFilter = "item = '" + itm + "'";
            filterreg = filter.ToTable();



            dtgvstock.AutoGenerateColumns = false;
            dtgvstock.DataSource = filterreg;

        }

        private void lbtndelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {


                if (dtgvstock.CurrentCell != null)
                {


                    //Restore Stock Quantity or Not
                    string message1 = "Confirm To Delete";
                    string title1 = "Delete";
                    MessageBoxButtons buttons1 = MessageBoxButtons.YesNo;
                    DialogResult result1 = MessageBox.Show(message1, title1, buttons1, MessageBoxIcon.Question);
                    if (result1 == DialogResult.Yes)
                    {


                        string ID = dtgvstock.CurrentRow.Cells[4].Value.ToString();   //get the ID value

                        //filter datatable
                        DataRow[] row = dtreg.Select("ID ='" +ID+ "'");
                        DataRow row1 = row[0]; //get unique row from the array
                        int index = dtreg.Rows.IndexOf(row1); //get index of datatable


                        dtreg.Rows.RemoveAt(index);

                        DataTable dats = new DataTable();
                        dats = dtreg.Copy();


                        dats.TableName = "reg";
                        dats.WriteXml("ItemRegister.xml");

                        dtgvstock.AutoGenerateColumns = false;
                        dtgvstock.DataSource = dats;



                        //int rowind = dtgvstock .CurrentRow .Index;
                        //dtgvstock.Rows.RemoveAt(rowind);


                        allreg();




                        ////Refresh Frmmain Cbxtraintype
                        //Frmmain form = Application.OpenForms.OfType<Frmmain>().FirstOrDefault();
                        //if (form != null)
                        //{

                        //    form.alltrain();

                        //}

                    }


                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }



        public void edtprice( string prc, string ID)
        {


           ID = dtgvstock.CurrentRow.Cells[4].Value.ToString();   //get the ID value

            string IDedt = ID;

            //filter datatable
            DataRow[] row = dtreg.Select("ID ='" + ID + "'");
            DataRow row1 = row[0]; //get unique row from the array
            int index = dtreg.Rows.IndexOf(row1); //get index of datatable

            dtreg.Rows[index]["Price"] = prc;


            DataTable dats = new DataTable();
            dats = dtreg.Copy();


            dats.TableName = "reg";
            dats.WriteXml("ItemRegister.xml");

            indexchange();
        }





        public void edtqty(string qty, string ID)
        {
             ID = dtgvstock.CurrentRow.Cells[4].Value.ToString();   //get the ID value

            string IDedt = ID;

            //filter datatable
            DataRow[] row = dtreg.Select("ID ='" + ID + "'");

            //MessageBox.Show(row.Count().ToString()); 

            DataRow row1 = row[0]; //get unique row from the array
            int index = dtreg.Rows.IndexOf(row1); //get index of datatable

            dtreg.Rows[index]["Stockqty"] = qty;


            DataTable dats = new DataTable();
            dats = dtreg.Copy();

            dats.TableName = "reg";
            dats.WriteXml("ItemRegister.xml");

            indexchange();

        }













        public static string oldprice;
        public static string itemdesc;
        public static string edtID;
        public static string oldqty;
        private void lbtnedtprice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            oldprice = dtgvstock.CurrentRow.Cells[2].Value.ToString();
            itemdesc = dtgvstock.CurrentRow.Cells[0].Value.ToString();
            edtID= dtgvstock.CurrentRow.Cells[3].Value.ToString();

            FrmeditPrice f1 = new FrmeditPrice();
            f1.Show();

            //string pr = "50";
            //edtprice(pr);

        }

        private void lbtnedtstockqty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           edtID = dtgvstock.CurrentRow.Cells[3].Value.ToString();
            itemdesc = dtgvstock.CurrentRow.Cells[0].Value.ToString();
            oldqty = dtgvstock.CurrentRow.Cells[1].Value.ToString();

           Frmeditqty f1 = new Frmeditqty();
            f1.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            edtID = dtgvstock.CurrentRow.Cells[4].Value.ToString();
            itemdesc = dtgvstock.CurrentRow.Cells[0].Value.ToString();
            oldqty = dtgvstock.CurrentRow.Cells[1].Value.ToString();



            Frmaddstockqty f1 = new Frmaddstockqty();
            f1.Show();
        }

        private void ViewStock_Load(object sender, EventArgs e)
        {

        }

        private void dtgvstock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegister f1 = new FrmRegister();
            f1.Show();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
