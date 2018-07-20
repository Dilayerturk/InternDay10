using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public class XmlImportExport : IPersonExporter
    {
        public String FileExtension => ".xml";

        public String Name
        {
            get { return "XML"; }
        }

        public BindingList<Person> Open(String filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Person>));
            StreamReader reader = new StreamReader(filePath);
            var input = (BindingList<Person>)serializer.Deserialize(reader);
            return input;
        }

        public void Save(String filePath, BindingList<Person> personList)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Person>));
            StreamWriter writer = new StreamWriter(filePath);
            serializer.Serialize(writer, personList);
            writer.Close();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
