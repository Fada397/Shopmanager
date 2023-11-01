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
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
        }

        private void btnselectfolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fold = new FolderBrowserDialog();
            DialogResult result = fold.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fold.SelectedPath))
            {
                //string[] files = Directory.GetFiles(fold.SelectedPath);

                tbxselcttfolder.Text = fold.SelectedPath.ToString();
            }
        }

        private void Btnbackup_Click(object sender, EventArgs e)
        {
            try
            {

                File.Copy("ItemRegister.xml", tbxselcttfolder.Text + "\\ItemRegister.xml", true);
                File.Copy("sales.xml", tbxselcttfolder.Text + "\\Sales.xml", true);
               
                MessageBox.Show("Backup Successful");

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void lnlrestore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {

                string path1 = Path.GetFullPath("ItemRegister.xml");
                string path2 = Path.GetFullPath("Sales.xml");
                 //try
                //{
                string message = "Restore will overwrite current data";
                string title = "Restore";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    //restore
                    File.Copy(tbxselcttfolder.Text + "\\ItemRegister.xml", path1, true);
                    File.Copy(tbxselcttfolder.Text + "\\Sales.xml", path2, true);
                   
                    MessageBox.Show("Restore Successful");

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
