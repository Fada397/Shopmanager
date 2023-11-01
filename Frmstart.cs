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
    public partial class Frmstart : Form
    {
        public Frmstart()
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
        }


        private void Frmstart_Load(object sender, EventArgs e)
        {

        }

        public static string priv;
        public static string usernam;
        public static string nam;
        private void btnlogin_Click(object sender, EventArgs e)
        {
      
                string usern = this.tbxusername.Text.Trim();
                string pass = this.tbxpassword.Text.Trim();
                DataRow[] row = dtlog.Select("Username ='" + usern + "' AND Password ='"+pass+"'");
                int count = row.Count();


            if (count > 0)
            {

                string pass1 = row[0]["Password"].ToString(); 
                 if ( pass == pass1)   //to cater for lettercase
                {
                    priv = row[0]["Privilege"].ToString(); 
                    usernam = row[0]["Username"].ToString();
                    nam = row[0]["Name"].ToString();

                    frmMain f1 = new frmMain();
                    f1.ShowDialog();

                    tbxpassword.Clear();
                    tbxusername.Clear();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }



        }
    }
}
