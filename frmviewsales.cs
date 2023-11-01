using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopmanager
{
    public partial class frmviewsales : Form
    {
        public frmviewsales()
        {
            InitializeComponent();
            allreg();
            autocomplete();
            allsales();
            all_login();
        }


        DataTable dtreg = new DataTable();
        DataTable dtreg1 = new DataTable();
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

            cbxitem.Items.AddRange(postSource);
            cbxitem.SelectedIndex = -1;

            cbxitem.Items.Insert(0, "All items");
            //Note combobox(cbxitem) can only be set to selected index -1 if not databinded thereby adding data by addrang , array
        }


        //get all login
        DataTable dtlog = new DataTable();
        DataTable dtlog1 = new DataTable();
        public void all_login()
        {
            Clslogin logins = new Clslogin();
            logins.selectlogin();
            dtlog = logins.dtlogin.Copy();

           
            if (dtlog.Rows.Count != 0)
            {

                //convert item row to array
                string[] postSource = dtlog
                       .AsEnumerable()
                       .Select<System.Data.DataRow, String>(x => x.Field<String>("Username"))
                       .ToArray();


                cbxpers.Items.Clear();
                cbxpers.Items.AddRange(postSource);
                cbxpers.SelectedIndex = 0;
                cbxpers.Items.Insert(0, "All");
            }


        }

        DataTable dtsales1 = new DataTable();
        private void allsales()
        {
           
            ClsSales viewsale = new ClsSales();
            viewsale.selectsales();
            dtsales1 = viewsale.dtsales.Copy();
          
            }




        private void autocomplete()
        {
            string[] postSource = dtreg1
                    .AsEnumerable()
                    .Select<System.Data.DataRow, String>(x => x.Field<String>("Item"))
                    .ToArray();

            var source = new AutoCompleteStringCollection();
            source.AddRange(postSource);
            cbxitem.AutoCompleteCustomSource = source;

            //textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        DataTable filterdtble = new DataTable();
        public void allitems()
        {

            filterdtble.Rows.Clear();


            string date1 = Dtmfrom.Value.ToString("MMM. dd, yyyy");
            string date2 = DteTo.Value.ToString("MMM. dd, yyyy");

            DataView filter = new DataView(dtsales1);

            //check if filter has data
            if (filter.Count > 0)
            {
                filter.RowFilter = "seldate >= #" + date1 + "# AND seldate <= #" + date2 + "# ";
                filterdtble = filter.ToTable();
            }


            var totprice = filterdtble.AsEnumerable()
                   .Sum(x => Convert.ToInt32(x["totalcost"]));   //use this LINQ if column is of type string
            // decimal totprice = Convert.ToDecimal(filterdtble.Compute("SUM(totalcost)", string.Empty));
            lbltotsalesprice.Text = totprice.ToString();




            var totprof = filterdtble.AsEnumerable()
                 .Sum(x => Convert.ToInt32(x["profit"]));   //use this LINQ if column is of type string
            // decimal totprice = Convert.ToDecimal(filterdtble.Compute("SUM(totalcost)", string.Empty));
            lbltotprofit.Text = totprof.ToString();





            dtgvsales.AutoGenerateColumns = false;
            dtgvsales.DataSource = filterdtble;

        }



       // DataTable filtable = new DataTable();
        public void filter_specificTrainingAllpers()
        {

            filterdtble.Rows.Clear();
            string date1 = Dtmfrom.Value.ToString("MMM. dd, yyyy");
            string date2 = DteTo.Value.ToString("MMM. dd, yyyy");
            string itm = this.cbxitem.GetItemText(cbxitem.SelectedItem);

            DataView filter = new DataView(dtsales1);


            //check if filter has data
            if (filter.Count > 0)
            {
                filter.RowFilter = "seldate >= #" + date1 + "# AND seldate <= #" + date2 + "# AND item = '" + itm + "'";
                filterdtble = filter.ToTable();
            }


            var totprice = filterdtble.AsEnumerable()
                  .Sum(x => Convert.ToInt32(x["totalcost"]));   //use this LINQ if column is of type string
            //// decimal totprice = Convert.ToDecimal(filterdtble.Compute("SUM(totalcost)", string.Empty));
            lbltotsalesprice.Text = totprice.ToString();



            var totprof = filterdtble.AsEnumerable()
                .Sum(x => Convert.ToInt32(x["profit"]));   //use this LINQ if column is of type string
            // decimal totprice = Convert.ToDecimal(filterdtble.Compute("SUM(totalcost)", string.Empty));
            lbltotprofit.Text = totprof.ToString();


            dtgvsales.AutoGenerateColumns = false;
            dtgvsales.DataSource = filterdtble;

        }




        public void filter_specificitems_specificpers()
        {

            filterdtble.Rows.Clear();
            string date1 = Dtmfrom.Value.ToString("MMM. dd, yyyy");
            string date2 = DteTo.Value.ToString("MMM. dd, yyyy");
            string itm = this.cbxitem.GetItemText(cbxitem.SelectedItem);
            string pers1 = this.cbxpers.GetItemText(cbxpers.SelectedItem);


            DataView filter = new DataView(dtsales1);


            //check if filter has data
            if (filter.Count > 0)
            {
                filter.RowFilter = "seldate >= #" + date1 + "# AND seldate <= #" + date2 + "# AND item = '" + itm + "'  AND Personnel = '" + pers1 + "'" ;
                filterdtble = filter.ToTable();
            }


            var totprice = filterdtble.AsEnumerable()
                  .Sum(x => Convert.ToInt32(x["totalcost"]));   //use this LINQ if column is of type string
            //// decimal totprice = Convert.ToDecimal(filterdtble.Compute("SUM(totalcost)", string.Empty));
            lbltotsalesprice.Text = totprice.ToString();



            var totprof = filterdtble.AsEnumerable()
                .Sum(x => Convert.ToInt32(x["profit"]));   //use this LINQ if column is of type string
            // decimal totprice = Convert.ToDecimal(filterdtble.Compute("SUM(totalcost)", string.Empty));
            lbltotprofit.Text = totprof.ToString();


            dtgvsales.AutoGenerateColumns = false;
            dtgvsales.DataSource = filterdtble;

        }


        public void filter_allitems_specificpers()
        {


            filterdtble.Rows.Clear();
            string date1 = Dtmfrom.Value.ToString("MMM. dd, yyyy");
            string date2 = DteTo.Value.ToString("MMM. dd, yyyy");
            string itm = this.cbxitem.GetItemText(cbxitem.SelectedItem);
            string pers1 = this.cbxpers.GetItemText(cbxpers.SelectedItem);


            DataView filter = new DataView(dtsales1);


            //check if filter has data
            if (filter.Count > 0)
            {
                filter.RowFilter = "seldate >= #" + date1 + "# AND seldate <= #" + date2 + "# AND Personnel = '" + pers1 + "'";
                filterdtble = filter.ToTable();
            }


            var totprice = filterdtble.AsEnumerable()
                  .Sum(x => Convert.ToInt32(x["totalcost"]));   //use this LINQ if column is of type string
            //// decimal totprice = Convert.ToDecimal(filterdtble.Compute("SUM(totalcost)", string.Empty));
            lbltotsalesprice.Text = totprice.ToString();



            var totprof = filterdtble.AsEnumerable()
                .Sum(x => Convert.ToInt32(x["profit"]));   //use this LINQ if column is of type string
            // decimal totprice = Convert.ToDecimal(filterdtble.Compute("SUM(totalcost)", string.Empty));
            lbltotprofit.Text = totprof.ToString();


            dtgvsales.AutoGenerateColumns = false;
            dtgvsales.DataSource = filterdtble;

        }


        public void search() {
            if (cbxitem.SelectedIndex == 0 && cbxpers.SelectedIndex == 0) { allitems(); }  //All items and all persons


            else if (cbxitem.SelectedIndex > 0 && cbxpers.SelectedIndex == 0)   //specific item and all personsons
            { filter_specificTrainingAllpers(); }


            else if (cbxitem.SelectedIndex > 0 && cbxpers.SelectedIndex > 0)   //specific items and specific personsons
            {
                filter_specificitems_specificpers();
            }

            else if (cbxitem.SelectedIndex == 0 && cbxpers.SelectedIndex > 0)   //all items and specific personsons
            {
                filter_allitems_specificpers();
            }
        }


        private void btnsearch_Click(object sender, EventArgs e)
        {
            
            search();


        }

        private void frmviewsales_Load(object sender, EventArgs e)
        {

        }

        private void lbtndelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            //try
            //{


                if (dtgvsales.CurrentCell != null)
                {


                    //Restore Stock Quantity or Not
                    string message1 = "Confirm To Delete";
                    string title1 = "Delete";
                    MessageBoxButtons buttons1 = MessageBoxButtons.YesNo;
                    DialogResult result1 = MessageBox.Show(message1, title1, buttons1, MessageBoxIcon.Question);
                    if (result1 == DialogResult.Yes)
                    {


                        string ID = dtgvsales.CurrentRow.Cells[6].Value.ToString();   //get the ID value

                        //filter datatable
                        DataRow[] row = dtsales1.Select("ID ='" + ID + "'");
                        DataRow row1 = row[0]; //get unique row from the array
                        int index = dtsales1.Rows.IndexOf(row1); //get index of datatable


                        dtsales1.Rows.RemoveAt(index);

                        DataTable dats = new DataTable();
                        dats = dtsales1.Copy();


                        dats.TableName = "sal";
                        dats.WriteXml("Sales.xml");

                        dtgvsales.AutoGenerateColumns = false;
                        dtgvsales.DataSource = dats;



                        //int rowind = dtgvstock .CurrentRow .Index;
                        //dtgvstock.Rows.RemoveAt(rowind);


                       allsales();

                    search();

                }


                }

            //}
            //catch (Exception ex) { MessageBox.Show(ex.ToString()); }








        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string mailBody = "<table width='100%' style='border:Solid 1px Black;'>";



            mailBody += "<tr>";
            //cteate table header
            for (int i = 0; i < dtgvsales.Columns.Count; i++)   
            {
                mailBody += ("<td align='center' valign='middle'>" +
                                dtgvsales.Columns[i].HeaderText + "</td>");
            }




            foreach (DataGridViewRow row in dtgvsales.Rows)
            {
                mailBody += "<tr>";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    mailBody += "<td   align='center' valign='middle'>" + cell.Value + "</td>";
                }
                mailBody += "</tr>";

            }
            mailBody += "</table>";






            var client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("fadaitems1@gmail.com", "plzw qwel jdid yilq");
            
            var mail = new MailMessage();
            mail.IsBodyHtml = true;
            mail.From = new MailAddress("fadaitems1@gmail.com");
            mail.To.Add("fadafcg@gmail.com");
            mail.Subject = "Sales";
            mail.Body = mailBody;
            client.Send(mail);
        }
    }
}
