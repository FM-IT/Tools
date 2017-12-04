using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace CreateXMLFromXSD
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument myXMLDoc = new XmlDocument();
            myXMLDoc.Load("C:\\Opgaver\\Mobile\\XML\\XMLRequest.XML");
            System.Xml.Schema.XmlSchema XS = new System.Xml.Schema.XmlSchema();
            XS = "C:\\Development\\CreateXMLFromXSD\\CreateXMLFromXSD\\XMLSchema1.xsd";
            myXMLDoc.Schemas.Add(XS);
            System.Xml.Schema.ValidationEventHandler VE;
            myXMLDoc.Validate(VE);
            string st = Console.ReadLine();
            pick myPickXML = new pick();
            myPickXML.PickHeaders.PickHeaderProperties.
        }
    }
}