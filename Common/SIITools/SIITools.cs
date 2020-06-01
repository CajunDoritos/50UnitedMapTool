using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _50UnitedMapTool.Common.SIITools
{
    class SIITools
    {
        //Convert SII files to XML to be readable by a machine
        public static XmlDocument SIIToXML(string manifest)
        {



            using (StringWriter sw = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sw)) { 

                }
            }

            //Placeholder so the program compiles
            return new XmlDocument();
        }

    }
}
