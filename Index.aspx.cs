using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;

namespace XMLSerialize
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*No code here*/
        }

        protected void btnSerialize_Click(object sender, EventArgs e)
        {
            var objShipOrder = new XMLClass.shiporder();
            var objShipOrderItem = new XMLClass.shiporderItem();
            var objShipTo = new XMLClass.shiporderShipto();

            objShipTo.address = "Address Value";
            objShipTo.city = "City Value";
            objShipTo.country = "Country Value";
            objShipTo.name = "Name Value";

            objShipOrderItem.title = "Title Value";
            objShipOrderItem.quantity = "0";
            objShipOrderItem.price = 0;
            objShipOrderItem.note = "Note Value";

            XMLClass.shiporderItem[] shipOrderItens = new XMLClass.shiporderItem[1];
            shipOrderItens[0] = objShipOrderItem;

            objShipOrder.item = shipOrderItens;
            objShipOrder.shipto = objShipTo;

            objShipOrder.orderid = "0";
            objShipOrder.orderperson = "Person Value";

            //Serialize
            XmlSerializer serializer = new XmlSerializer(typeof(XMLClass.shiporder));
            serializer.Serialize(File.Create("C:\\XML\\OrderShip.xml"), objShipOrder);
        }

        protected void btnDeserialize_Click(object sender, EventArgs e)
        {
            var objShipOrder = new XMLClass.shiporder();

            //Serialize
            XmlSerializer serializer = new XmlSerializer(typeof(XMLClass.shiporder));

            StreamReader stReader = new StreamReader("C:\\XML\\OrderShip.xml");
            objShipOrder = (XMLClass.shiporder)serializer.Deserialize(stReader);
            stReader.Close();
        }
    }
}