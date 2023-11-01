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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            fullscreen();
            logininfo();
        }
        private void fullscreen() 
        {
            
            //this.TopMost=true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Maximized;

          
        }

        string privi;
        string nam1;
        string usernm1;
        public void logininfo()
        {
            privi = Frmstart.priv;
            nam1 = Frmstart.nam;
            usernm1 = Frmstart.usernam;


            lblpersonnelname.Text = nam1;

            if (privi == "0")
            {lnkprices.Visible = false; lnksales.Visible = false;lnkstock.Visible = false;lnkpersonell.Visible = false; }


           //frmMain f1 = new frmMain();
           // f1.Close();
        }





        private void Frmstart_Load(object sender, EventArgs e)
        {

        }

        private void lnksales_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmviewsales f1 = new frmviewsales();
            f1.ShowDialog();
        }

        private void btnsell_Click(object sender, EventArgs e)
        {
            Frmsales1 f1 = new Frmsales1();
            f1.ShowDialog();
        }

        private void lnkstock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           ViewStock f1 = new ViewStock();
            f1.ShowDialog();
        }

        private void lnkprices_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           ViewStock f1 = new ViewStock();
            f1.ShowDialog();
        }

        private void lnkpersonell_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmlogin f1 = new frmlogin();
            f1.ShowDialog();
        }

        private void lnkbackup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Backup f1 = new Backup();
            f1.ShowDialog();
        }
    }
}
