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
    public class CsvImportExport : ICsvImportExport
    {
        public String FileExtension => ".csv";
        public String Name => "csv";

        public BindingList<Person> Open(String filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                BindingList<Person> personList = new BindingList<Person>();
                string line = sr.ReadLine();
                line = sr.ReadLine();

                while (!String.IsNullOrEmpty( line))
                {
                    String[] arr = line.Split(',');
                    Person _person = new Person
                    {
                        TCNo = arr[0],
                        Name = arr[1],
                        Surname = arr[2],
                        Gender = arr[3],
                        Birthday = arr[4]
                    };
                    personList.Add(_person);
                    line = sr.ReadLine();
                }
                return personList;
            }
        }

        public void Save(String filePath, BindingList<Person> personList)
        {
            using (StreamWriter sw = new StreamWriter(File.Create(filePath)))
            {
                sw.WriteLine("TCNo,Name,Surname,Gender,Birthdate");
                for (int i = 0; i < personList.Count; i++)
                {
                    Person _person = personList[i];
                    sw.WriteLine($"{_person.TCNo},{_person.Name},{_person.Surname},{_person.Gender},{_person.Birthday}");
                }
            }
        }
    }
}






