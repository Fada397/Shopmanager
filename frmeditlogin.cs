using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopmanager
{
    public partial class frmeditlogin : Form
    {
        public frmeditlogin()
        {
            InitializeComponent();
            all_login();

        }



        //get all login
        DataTable dtlog = new DataTable();
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
                cbxusername.Items.Clear();
                cbxusername.Items.AddRange(postSource);
                cbxusername.SelectedIndex = 0;
            }


        }




        //filter sales ....specific item//
        DataTable filterreg = new DataTable();
        public void filter_specificitems()
        {
            string user = this.cbxusername.GetItemText(cbxusername.SelectedItem); ;
            DataView filter = new DataView(dtlog);
            filter.RowFilter = "Username = '" + user + "'";
            filterreg = filter.ToTable();


            tbxpasword.Text = filterreg.Rows[0]["Password"].ToString();
            tbxname.Text = filterreg.Rows[0]["Name"].ToString();
            string priv = filterreg.Rows[0]["Privilege"].ToString();

            //if (priv == "1") { cbxpriv.SelectedIndex = 0; }
            //else if (priv == "0") { cbxpriv.SelectedIndex = 1; }

        }




        private void btnsave_Click(object sender, EventArgs e)
        {

            string user = this.cbxusername.GetItemText(cbxusername.SelectedItem);

            //filter datatable
            DataRow[] row = dtlog.Select("Username ='" + user + "'");

            //MessageBox.Show(row.Count().ToString()); 

            DataRow row1 = row[0]; //get unique row from the array
            int index = dtlog.Rows.IndexOf(row1); //get index of datatable

            dtlog.Rows[index]["Password"] = tbxpasword.Text.Trim().ToString();
            dtlog.Rows[index]["Name"] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tbxname.Text.Trim().ToLower());


            DataTable dats = new DataTable();
            dats = dtlog.Copy();

            dats.TableName = "log";
            dats.WriteXml("Login.xml");


            MessageBox.Show("Saved");





        }

        private void cbxusername_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter_specificitems();
        }



        private void delt()
        { //Restore Stock Quantity or Not
            string message1 = "Confirm To Delete";
            string title1 = "Delete";
            MessageBoxButtons buttons1 = MessageBoxButtons.YesNo;
            DialogResult result1 = MessageBox.Show(message1, title1, buttons1, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                string user = this.cbxusername.GetItemText(cbxusername.SelectedItem);
                //filter datatable
                DataRow[] row = dtlog.Select("Username ='" + user + "'");
                DataRow row1 = row[0]; //get unique row from the array
                int index = dtlog.Rows.IndexOf(row1); //get index of datatable


                dtlog.Rows.RemoveAt(index);

                DataTable dats = new DataTable();
                dats = dtlog.Copy();


                dats.TableName = "log";
                dats.WriteXml("Login.xml");

                all_login();

                ////Refresh login
                frmlogin form = Application.OpenForms.OfType<frmlogin>().FirstOrDefault();
                if (form != null)
                {

                    form.all_login();

                }



                ////Refresh Main Page
                frmMain form1 = Application.OpenForms.OfType<frmMain>().FirstOrDefault();
                if (form1 != null)
                {

                    form1.logininfo();

                }
                Frmstart form2 = Application.OpenForms.OfType<Frmstart>().FirstOrDefault();
                if (form2 != null)
                {

                    form2.all_login();

                }


            }
        }


        private void lbtndelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (cbxusername.SelectedIndex > -1)
            {
                string user = this.cbxusername.GetItemText(cbxusername.SelectedItem);
                //filter datatable
                DataRow[] row = dtlog.Select("Username ='" + user + "'");
                string priv1 = row[0]["Privilege"].ToString();

                if (priv1 == "1")
                {
                    DataRow[] rw1 = dtlog.Select("Privilege ='" + priv1 + "'");
                    int rcount = int.Parse(rw1.Count().ToString());

                    if (rcount == 1)
                    {
                        MessageBox.Show("All admins cannot be deleted");
                    }
                    else if (rcount > 1)
                    {

                        delt();

                    }
                }
                else if (priv1 == "0") { delt(); }
            }
        }
    }
}
