using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopmanager
{
    public partial class FrmeditPrice : Form
    {
        public FrmeditPrice()
        {
            InitializeComponent();
            prices();
        }


        string pric;
        string item;
        string itemID;
        public void prices()
        {
            pric = ViewStock.oldprice;
            item = ViewStock.itemdesc;
            itemID = ViewStock.edtID;

            lblitemdescription.Text = item;
            tbxprice.Text = pric;

        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            string newprice = tbxprice.Text.ToString().Trim();
            if (newprice != "")
            {
                
                //ViewStock pr = new ViewStock();
                //pr.edtprice(newprice,itemID);



                //referesh viewstock page
                ViewStock form = Application.OpenForms.OfType<ViewStock>().FirstOrDefault();
                if (form != null)
                {
                    form.edtprice(newprice, itemID);

                }

                MessageBox.Show("Saved");
                //this.Close();

            }
        }

     
        private void tbxprice_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
