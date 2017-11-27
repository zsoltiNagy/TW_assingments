using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization
{
    public partial class Form1 : Form
    {
        private string appPath;
        private List<string> persons;
        int currentIndex;

        public Form1()
        {
            OnLoad();
        }

        private void OnLoad()
        {
            InitializeComponent();
            SetAppPath();
            FillpersonsList();
            if (persons.Count > 0)
            {
                FillListBox();
                currentIndex = 0;
                FillFieldsFromIndex(currentIndex);
            }
        }

        private void SetAppPath()
        {
            appPath = Path.GetDirectoryName(Application.ExecutablePath);
            CurrentPath.Text = appPath;
        }

        private void FillpersonsList()
        {
            persons = new List<string>();
            foreach (string fileName in Directory.GetFiles(appPath, "person*.dat"))
            {
                persons.Add(fileName);
            }

        }

        private void FillFieldsFromIndex(int index)
        {
            string path = persons.ElementAt(index);
            Person person = Person.Deserialize(path);
            NameTextBox.Text = person.Name;
            AddressTextBox.Text = person.Address;
            PhoneTextBox.Text = person.Phone;
            SerialNumberLabel.Text = "#" + person.GetSerialNumber();
        }

        private void FillFieldsFromPerson(Person person)
        {
            NameTextBox.Text = person.Name;
            AddressTextBox.Text = person.Address;
            PhoneTextBox.Text = person.Phone;
            SerialNumberLabel.Text = "#" + person.GetSerialNumber();
        }

        private void FillListBox()
        {
            FileBox.Items.Clear();
            foreach (string fileName in persons)
            {
                FileBox.Items.Add(fileName);
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!Validator.ValidName(NameTextBox.Text))
            {
                MessageBox.Show("The name is invaid (only alphabetical characters are allowed)");
            }
            else if (!Validator.ValidPhoneNumber(PhoneTextBox.Text))
            {
                MessageBox.Show("The phone number is not a valid  US phone number." +
                    "\n Next time use something like this: (111) 111-1111)");
            }
            else
            {
                Person person = new Person(NameTextBox.Text,
                    AddressTextBox.Text, PhoneTextBox.Text);
                persons.Add(appPath + "\\person" + person.GetSerialNumber() + ".dat");
                persons.Sort();
                person.Serialize();
                FillListBox();
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            currentIndex += 1;
            if (currentIndex > persons.Count - 1)
            {
                currentIndex = 0;
            }
            FillFieldsFromIndex(currentIndex);
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            currentIndex -= 1;
            if(currentIndex < 0)
            {
                currentIndex = persons.Count - 1;
            }
            FillFieldsFromIndex(currentIndex);
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            FillFieldsFromIndex(0);
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            FillFieldsFromIndex(persons.Count -1);
        }

        private void FileBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = FileBox.SelectedItem.ToString();
            Person person = Person.Deserialize(path);
            FillFieldsFromPerson(person);
        }
    }
}
