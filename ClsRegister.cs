using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace shopmanager
{
    internal class ClsRegister
    {

        public void registerinsert(string Item, string stockqty, string price, string cprice)
        {
            //count all riders to set auto ID
            DataSet ds = new DataSet();
            ds.ReadXml("ItemRegister.xml");

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
            xmlregDoc.Load("ItemRegister.xml");
            XmlElement ParentElement = xmlregDoc.CreateElement("reg");

            XmlElement ID = xmlregDoc.CreateElement("ID");
            ID.InnerText = countid;

            XmlElement item = xmlregDoc.CreateElement("Item");
            item.InnerText = Item;

            XmlElement stockquantity = xmlregDoc.CreateElement("Stockqty");
            stockquantity.InnerText = stockqty;


            XmlElement itemprice = xmlregDoc.CreateElement("Price");
            itemprice.InnerText = price;


            XmlElement costprice = xmlregDoc.CreateElement("Costprice");
            costprice.InnerText = cprice;




            ParentElement.AppendChild(ID);
            ParentElement.AppendChild(item);
            ParentElement.AppendChild(stockquantity);
            ParentElement.AppendChild(itemprice);
            ParentElement.AppendChild(costprice);

            xmlregDoc.DocumentElement.AppendChild(ParentElement);
            xmlregDoc.Save("ItemRegister.xml");
        }

               
        public DataTable dtregister = new DataTable();
        public void selectregister()
        {
            DataSet ds = new DataSet();
            ds.ReadXml("ItemRegister.xml");
            if (ds.Tables.Count > 0) { dtregister = ds.Tables[0]; }
        }





    }
}
