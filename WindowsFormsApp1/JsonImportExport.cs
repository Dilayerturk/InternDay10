using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public class JsonImportExport : IJsonImportExport
    {
        public String FileExtension => ".json";

        public String Name
        {
            get { return "JSON"; }
        }

        public BindingList<Person> Open(String filePath)
        {
            return JsonConvert.DeserializeObject<BindingList<Person>>(File.ReadAllText(filePath));
        }

        public void Save(String filePath, BindingList<Person> personList)
        {
            string _strJson = JsonConvert.SerializeObject(personList);
            File.WriteAllText(filePath, _strJson);
        }
    }
}
