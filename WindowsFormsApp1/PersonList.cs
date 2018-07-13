using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CsvHelper;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WindowsFormsApp1
{   

    public partial class PersonList : Form
    {
       BindingList<Person> personList;

        public PersonList()
        {
            InitializeComponent();
            gridViewPerson.AutoGenerateColumns = false;
            personList = new BindingList<Person>();
            gridViewPerson.DataSource = personList;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            using (PersonOperation frm = new PersonOperation())
            {
                Person _person = new Person() { TCNo = "308451234", Surname = "Erturk", Name = "Dilay", Gender = "Female", Birthday = "1996-08-06" };
                frm.EditedPerson = _person;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    personList.Add(_person);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridViewPerson.SelectedRows.Count > 0)
            {
                var _selectedRow = gridViewPerson.CurrentRow;
                Person _person = (Person)_selectedRow.DataBoundItem;
                PersonOperation frm = new PersonOperation();
                frm.EditedPerson = _person;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    
                } 
            }
            else
            {
                MessageBox.Show("Please select a person!");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (gridViewPerson.SelectedRows.Count > 0)
            {
                var _selectedRow = gridViewPerson.CurrentRow;

                Person _person = (Person)_selectedRow.DataBoundItem;

                DialogResult = MessageBox.Show($"Do you want to delete '{_person.Name}'?", "Warning!", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    personList.Remove(_person);
                }
                else
                {
                    MessageBox.Show("NOT DELETED!");
                }
            }
            else
            {
                MessageBox.Show("Please select a person!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnBindList_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmbBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if(cmbBoxType.SelectedItem == null)
            {
                MessageBox.Show("Please select the type of file from combo box !");
            }
            else
            {
                if (cmbBoxType.Text == ".csv")
                {
                    CsvSave();
                }
                else if (cmbBoxType.Text == ".xml")
                {
                    XMLSave();
                }
                else
                {
                    JsonSave();
                }
            }
                
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

            if (cmbBoxType.SelectedItem == null)
            {
                MessageBox.Show("Please select the type of file from combo box !");
            }
            else
            {
                if (cmbBoxType.Text == ".csv")
                {
                    CsvOpen();
                }
                else if (cmbBoxType.Text == ".xml")
                {
                    XMLOpen();
                }
                else
                {
                    JsonOpen();
                }
            }
            
        }

        public void CsvOpen()
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|* .csv", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var sr = new StreamReader(new FileStream(ofd.FileName, FileMode.Open));
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        line = sr.ReadLine();
                        if (String.IsNullOrEmpty(line) == false)
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
                        }
                    }
                    sr.Close();
                }
            }

        }

        public void XMLOpen ()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML|*.xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var path = ofd.FileName;
                XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Person>));
                StreamReader reader = new StreamReader(path);
                var input =(BindingList<Person>) serializer.Deserialize(reader);
                gridViewPerson.DataSource = input;
                personList = input;
            }
        }

        public void JsonOpen()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JSON|*.json";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string strJson = File.ReadAllText(ofd.FileName);
                var input = JsonConvert.DeserializeObject<BindingList<Person>>(strJson);
                gridViewPerson.DataSource = input;
                personList = input;
            }
        }
        public void CsvSave()
        {
            saveFileDialog.Title = "Please choose the type of document";
            saveFileDialog.Filter = "|*.csv";
            saveFileDialog.FileName = "";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(File.Create(saveFileDialog.FileName));
                sw.WriteLine("TC,No,Name,Surname,Gender,Birthday");
                for (int i = 0; i < personList.Count; i++)
                {
                    Person _person = personList[i];
                    sw.WriteLine($"{_person.TCNo},{_person.Name},{_person.Surname},{_person.Gender},{_person.Birthday}\n");
                }
                MessageBox.Show("Data converted successfully");
                sw.Close();
            }
        }
        public void XMLSave()
        {
            saveFileDialog.Filter = "|*.xml";
            SaveFileDialog filedialog = new SaveFileDialog();

            if (filedialog.ShowDialog() == DialogResult.OK)
            {
                var path = filedialog.FileName;
                XmlSerializer serializer = new XmlSerializer(typeof(BindingList <Person>));
                StreamWriter writer = new StreamWriter(path);
                serializer.Serialize(writer, personList);
                writer.Close();
                MessageBox.Show("Data serialized successfully");
            }
        }
        public void JsonSave()
        {
            saveFileDialog.Filter = "|*.json";
            SaveFileDialog fileDialog = new SaveFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = fileDialog.FileName;
                JsonSerializer serializer = new JsonSerializer();
                serializer.Converters.Add(new JavaScriptDateTimeConverter());
                serializer.NullValueHandling = NullValueHandling.Ignore;
                StreamWriter writer = new StreamWriter(path,false, Encoding.UTF8);
                serializer.Serialize(writer, personList);
                writer.Close();
                MessageBox.Show("Data serialized successfully");
            } 
        }
            private void PersonList_Load(object sender, EventArgs e)
        {
        
        }
    }
}
