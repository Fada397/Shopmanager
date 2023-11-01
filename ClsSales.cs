using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace shopmanager
{
    internal class ClsSales
    {


        public void Salesinsert(string Item, string saleqty, string uprice, string scost,string date1, string profit, string per)
        {
            //count all riders to set auto ID
            DataSet ds = new DataSet();
            ds.ReadXml("Sales.xml");

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
            xmlregDoc.Load("Sales.xml");
            XmlElement ParentElement = xmlregDoc.CreateElement("sal");

            XmlElement ID = xmlregDoc.CreateElement("ID");
            ID.InnerText = countid;

            XmlElement item = xmlregDoc.CreateElement("Item");
            item.InnerText = Item;

            XmlElement salequantity = xmlregDoc.CreateElement("quantity");
            salequantity.InnerText = saleqty;


            XmlElement itemprice = xmlregDoc.CreateElement("unitprice");
            itemprice.InnerText = uprice;

            XmlElement salecost= xmlregDoc.CreateElement("totalcost");
            salecost.InnerText = scost;

            XmlElement seldate = xmlregDoc.CreateElement("seldate");
            seldate.InnerText = date1;

            XmlElement selprofit = xmlregDoc.CreateElement("profit");
            selprofit.InnerText = profit;

            XmlElement pers = xmlregDoc.CreateElement("Personnel");
            pers.InnerText =per;


            ParentElement.AppendChild(ID);
            ParentElement.AppendChild(item);
            ParentElement.AppendChild(salequantity);
            ParentElement.AppendChild(itemprice);
            ParentElement.AppendChild(salecost);
            ParentElement.AppendChild(selprofit);
            ParentElement.AppendChild(seldate);
            ParentElement.AppendChild(pers);


            xmlregDoc.DocumentElement.AppendChild(ParentElement);
            xmlregDoc.Save("Sales.xml");

        }



        public DataTable dtsales = new DataTable();
        public void selectsales()
        {
            DataSet ds = new DataSet();
            ds.ReadXml("Sales.xml");
            if (ds.Tables.Count > 0) { dtsales = ds.Tables[0]; }
        }




    }
}
