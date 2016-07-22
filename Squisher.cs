using System;
using System.IO;
using System.Xml.Linq;

namespace XMSquish
{
    public class Squisher : ISquisher
    {
        public void Squish(string fileName)
        {
            XDocument document = XDocument.Load(fileName);
            string squishedFileName = "squished"+fileName;
            FileStream writer = new FileStream(squishedFileName, FileMode.Create);
            document.Save(writer, SaveOptions.DisableFormatting);
        }
    }
}