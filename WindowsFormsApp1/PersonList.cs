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

        PersonExporterFactory exporterFactory;
        public PersonList()
        {
            InitializeComponent();
            gridViewPerson.AutoGenerateColumns = false;
            personList = new BindingList<Person>();
            gridViewPerson.DataSource = personList;

            exporterFactory = new PersonExporterFactory();

            fillExporterList();
        }

        private void fillExporterList()
        {
            cmbBoxType.DataSource = exporterFactory.GetSupportedExporterNames();
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

        private string selectFileForOpen(string filter)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = filter
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return ofd.FileName;
            }
            return null;
        }

        private string SelectFileForSave (string filter)
        {
            SaveFileDialog fileDialog = new SaveFileDialog
            {
                Filter = filter
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                return fileDialog.FileName;
            }
            return null;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (cmbBoxType.SelectedItem == null)
            {
                MessageBox.Show("Please select the type of file from combo box !");
            }
            else
            {
                string _selectedName = cmbBoxType.Text;
                IPersonExporter _exporter = exporterFactory.CreateExporter(_selectedName);
                string _filter = _exporter.Name + "|*" + _exporter.FileExtension;
                string _filePath = selectFileForOpen(_filter);

                if (_filePath != null)
                {
                    _exporter.Save(_filePath, personList);
                    MessageBox.Show("Data serialized successfully");
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
                string _selectedName = cmbBoxType.Text;
                IPersonExporter _exporter = exporterFactory.CreateExporter(_selectedName);

                string _filter = _exporter.Name + "|*" + _exporter.FileExtension;

                string _filePath = selectFileForOpen(_filter);

                if (_filePath != null)
                {
                    BindingList<Person> _loadedList = _exporter.Open(_filePath);
                    personList.Clear();
                    for (int i = 0; i < _loadedList.Count; i++)
                    {
                        personList.Add(_loadedList[i]);
                    }
                }                
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

        private void PersonList_Load(object sender, EventArgs e)
        {
        
        }
    }
}
