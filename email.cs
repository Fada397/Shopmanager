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
    public partial class email : Form
    {
        public email()
        {
            InitializeComponent();
        }

        private void btnemail_Click(object sender, EventArgs e)
        {
           
            
            //string mailBody = "<table width='100%' style='border:Solid 1px Black;'>";

            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    mailBody += "<tr>";
            //    foreach (DataGridViewCell cell in row.Cells)
            //    {
            //        mailBody += "<td stlye='color:blue;'>" + cell.Value + "</td>";
            //    }
            //    mailBody += "</tr>";
            //}
            //mailBody += "</table>";






            //var client = new SmtpClient("smtp.gmail.com", 587);
            //client.EnableSsl = true;
            //client.Credentials = new NetworkCredential("fadaitems1@gmail.com", "plzw qwel jdid yilq");

            //var mail = new MailMessage();
            //mail.From = new MailAddress("Fada");
            //mail.To.Add("fadafcg@gmail.com");
            //mail.Subject = "Windforms email";
            //mail.Body = "sending this mail from Shopmanager";
            //client.Send(mail);

        }
    }
}
