using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace shopmanager
{
    internal class Clslogin
    {

        public void Logininsert(string nam, string username1, string password1, string priv)
        {
            //count all riders to set auto ID
            DataSet ds = new DataSet();
            ds.ReadXml("Login.xml");

            string countid;
            if (ds.Tables.Count == 0) { countid = "0"; }
            else
            {
                DataTable dt = new DataTable();
                dt = ds.Tables[0];

                int ct = Convert.ToInt32(dt.Compute("max([ID])", string.Empty));
                countid = (ct + 1).ToString();
            }


            XmlDocument xmlregDoc = new XmlDocument();
            xmlregDoc.Load("Login.xml");
            XmlElement ParentElement = xmlregDoc.CreateElement("log");

            XmlElement ID = xmlregDoc.CreateElement("ID");
            ID.InnerText = countid;

            XmlElement name1 = xmlregDoc.CreateElement("Name");
            name1.InnerText = nam;

            XmlElement username = xmlregDoc.CreateElement("Username");
            username.InnerText = username1;
           

            XmlElement password = xmlregDoc.CreateElement("Password");
           password .InnerText = password1;

            XmlElement privilege = xmlregDoc.CreateElement("Privilege");
            privilege.InnerText = priv;


            ParentElement.AppendChild(ID);
            ParentElement.AppendChild(name1);
            ParentElement.AppendChild(username);
            ParentElement.AppendChild(password);
            ParentElement.AppendChild(privilege);



            xmlregDoc.DocumentElement.AppendChild(ParentElement);
            xmlregDoc.Save("Login.xml");

        }

        public DataTable dtlogin = new DataTable();
        public void selectlogin()
        {
            DataSet ds = new DataSet();
            ds.ReadXml("Login.xml");
            if (ds.Tables.Count > 0) { dtlogin = ds.Tables[0]; }
        }



    }
}
