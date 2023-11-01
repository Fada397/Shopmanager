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
    public partial class Frmeditqty : Form
    {
        public Frmeditqty()
        {
            InitializeComponent();
            qty();
        }



        string quant;
        string item;
        string itemID;
        public void qty()
        {
            quant = ViewStock.oldqty;
            item = ViewStock.itemdesc;
            itemID = ViewStock.edtID;

            lblitemdescription.Text = item;
           tbxqty.Text = quant;

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string newqty = tbxqty.Text.ToString().Trim();
            if (newqty != "")
            {

                //ViewStock pr = new ViewStock();
                //pr.edtprice(newprice,itemID);



                //referesh viewstock page
                ViewStock form = Application.OpenForms.OfType<ViewStock>().FirstOrDefault();
                if (form != null)
                {
                    form.edtqty(newqty, itemID);

                }

                MessageBox.Show("Saved");
                //this.Close();

            }
        }

        private void tbxqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
