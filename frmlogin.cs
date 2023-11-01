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
    public partial class frmlogin : Form
    {
        public frmlogin()
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


            cbxprivilege.SelectedIndex = 0;
        }

        public void inslogin()
        {
            string name1 = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tbxname.Text.Trim ().ToLower()); 
            string usname = tbxusername.Text.Trim();
            string pasword = tbxpasword.Text.Trim();
            string cpasword = tbxconfirmpassword.Text.Trim ();
            int countusern = usname .Split (' ').Length;    //count the number of words in username
          

            
            string priv1 = this.cbxprivilege.GetItemText(cbxprivilege.SelectedItem);
            string priv = ""; 
            if (priv1 == "Admin" ) 
            { priv = "1"; } 
            else if (priv1 == "Salesperson") { priv = "0"; }


            if (pasword == cpasword && name1 != "" && usname !="" && pasword != "" && countusern == 1)
            {
                Clslogin logins = new Clslogin();
                logins.Logininsert(name1 , usname, pasword,priv);

                MessageBox.Show("Saved");

                all_login();
                tbxname.Clear();
                tbxusername.Clear();
                tbxpasword.Clear();
                tbxconfirmpassword.Clear();

            }
            else
            { MessageBox.Show("Error, Check Data Entry"); }



        }



            private void btnsave_Click(object sender, EventArgs e)
        {
            try { 



            if (dtlog.Rows.Count > 0)   
            {

                //capitalize first letter of each word 
                string usern = this.tbxusername.Text.Trim();
                //filter datatable
                DataRow[] row = dtlog.Select("Username ='" + usern + "'");
                int count = row.Count();

                //int count = 0;
                if (count == 0)
                {
                    inslogin();


                }
                else
                {
                    MessageBox.Show("Item already exist");
                }
            }

            else
            {
                inslogin();




            }
        }
            catch (Exception ex) { MessageBox.Show("" + ex.Message.ToString() + ""); }


}

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void lbtndelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmeditlogin frm = new frmeditlogin();
            frm.ShowDialog();
        }
    }
}
