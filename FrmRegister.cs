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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace shopmanager
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
            allreg();
        }



        //get all register
        DataTable dtreg = new DataTable();
        public void allreg()
        {
            ClsRegister allregister = new ClsRegister();
            allregister.selectregister();
            dtreg = allregister.dtregister.Copy();

        }



        string item;
        decimal sellingprice, qty, costprice;
   

        //price accept numbers only  and  dot(.)
        private void tbxprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)   && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        public void insregister()
        {
            //capitalize first letter of each word 
            string item1 = this.tbxdescription.Text.Trim();
            item = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(item1.ToLower());


            sellingprice = decimal.Parse( tbxprice.Text.Trim());
            costprice = decimal.Parse(tbxcostprice.Text.Trim());
            qty = decimal.Parse(tbxstockqty.Text.Trim()); ;

         
            if (item != "" && sellingprice.ToString() !="")
            {
                ClsRegister regins = new ClsRegister();
                regins.registerinsert(item, qty.ToString(), sellingprice.ToString(), costprice.ToString()) ;
               
                allreg();



                tbxdescription.Clear();
                tbxprice.Clear();
                tbxstockqty.Clear();
                tbxcostprice.Clear();


                //referesh viewstock page
                ViewStock form = Application.OpenForms.OfType<ViewStock>().FirstOrDefault();
                if (form != null)
                {
                    form.allitems();
                    form.allreg();
                }

                MessageBox.Show("Saved");

            }
            else
            { MessageBox.Show("Error, Check Data Entry"); }

        }

        private void tbxcostprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbxstockqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnsaveregister_Click(object sender, EventArgs e)
        {
            try
            {


                if (dtreg.Rows.Count > 0)   //if register contains items check duplicate
                {

                    //capitalize first letter of each word 
                    string item1 = this.tbxdescription.Text.Trim();
                    item1 = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(item1.ToLower());


                    //filter datatable
                    DataRow[] row = dtreg.Select("Item ='" + item1+ "'");
                    int count = row.Count();

                    //int count = 0;
                    if (count == 0)
                    {
                        insregister();


                    }
                    else
                    {
                        MessageBox.Show("Item already exist");
                    }
                }

                else
                {
                    insregister();




                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message.ToString() + ""); }

        }
    }
}
