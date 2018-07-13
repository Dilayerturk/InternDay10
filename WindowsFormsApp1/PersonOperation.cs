using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PersonOperation : Form
    {
        private Person person;

        public Person EditedPerson
        {
            get { return person; }
            set
            {
                person = value;
                fillUIElements();
            }
        }

        public PersonOperation()
        {
            InitializeComponent();
        }

        private void fillUIElements()
        {
            txtTC.Text = person.TCNo;
            txtName.Text = person.Name;
            txtSurname.Text = person.Surname;
            cmbBoxGender.SelectedItem = person.Gender;
            birthDatePicker.Value = DateTime.ParseExact(person.Birthday, "yyyy-MM-dd", null);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            person.TCNo = txtTC.Text;
            person.Name = txtName.Text;
            person.Surname = txtSurname.Text;
            person.Gender = cmbBoxGender.SelectedItem.ToString();
            person.Birthday = birthDatePicker.Value.ToString("yyyy-MM-dd");
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
