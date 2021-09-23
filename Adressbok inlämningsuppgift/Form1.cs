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

namespace Adressbok_inlämningsuppgift
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Person> people = new List<Person>();
        string myPath = "Adresser.txt";

        private void BtnAddContact_Click(object sender, EventArgs e)
        {
            AddPerson();
            MessageBox.Show("Kontakten har lagts till i adressboken.");
            ListboxAdd();
            Empty();
        }

        private void OKbtn_Click(object sender, EventArgs e) 
        {
            string mySearch = txtSearch.Text;
              char c = ',';
            StreamReader reader = new StreamReader(myPath);

            if (rdBtnName.Checked)
            {
                foreach (string line in File.ReadAllLines(myPath))
                {
                    string[] chosen = line.Split(c);

                    if (chosen[0].Contains(mySearch))
                    {
                        lstBook.Items.Add(line);
                    }
                }
            }
            else if (rdBtnCity.Checked)
            {
                foreach (string line in File.ReadAllLines(myPath))
                {
                    string[] chosen = line.Split(c);

                    if (chosen[3].Contains(mySearch))
                    {
                        lstBook.Items.Add(line);
                    } 
                }
            }
            reader.Close();
        }

        private void TextBox_empty(object sender, MouseEventArgs e) 
        {
            txtSearch.Text = "";
        }

        private void Change_Click(object sender, EventArgs e)
        {
            char c = ',';
            string contact = lstBook.SelectedItem.ToString();
            string[] conArr = contact.Split(c);

            txtName.Text = conArr[0];
            txtStreet.Text = conArr[1];
            txtPstCode.Text = conArr[2];
            txtCity.Text = conArr[3];
            txtPhone.Text = conArr[4];
            txtEmail.Text = conArr[5];
        }

        private void BtnChange2_Click(object sender, EventArgs e)
        {
            Remove();
            AddPerson();
            MessageBox.Show("Kontakten har uppdaterats.");
            lstBook.Items.Remove(lstBook.SelectedItem);
            ListboxAdd();
            Empty();
            txtSearch.Text = "";
        }

        private void BtnShow_Click(object sender, EventArgs e) 
        {
            ShowContact();
        }

        private void LstBook_DbClick(object sender, EventArgs e)
        {
            if (lstBook.SelectedItem != null)
                ShowContact();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            Remove();
            lstBook.Items.Remove(lstBook.SelectedItem);

            FileInfo fi = new FileInfo(myPath);
            using (StreamReader reader = fi.OpenText())
            {
                string s = "";
                while ((s = reader.ReadLine()) != null)
                {
                    lstBook.Text = s;
                }
            }
            MessageBox.Show("Kontakten är borttagen från adressboken.");
            DeleteLabels();
        }

        private void Btn_EmptyList(object sender, EventArgs e)
        {
            lstBook.Items.Clear();
        }
        private void BtnShowDelete(object sender, EventArgs e)
        {
            DeleteLabels();
        }
        void Empty()
        {
            txtName.Text = "";
            txtStreet.Text = "";
            txtPstCode.Text = "";
            txtCity.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
        }
        void Remove()
        {
            string contactRemove = Convert.ToString(lstBook.SelectedItem);
            var oldFile = File.ReadAllLines(myPath);
            var newFile = oldFile.Where(line => !line.Contains(contactRemove));
            File.WriteAllLines(myPath, newFile);
            FileStream obj = new FileStream(myPath, FileMode.Append);
            obj.Close();
        }
        void AddPerson()
        {
            using (StreamWriter stream = File.AppendText(myPath))
            {
                Person contact = new Person(txtName.Text, txtStreet.Text, txtPstCode.Text, txtCity.Text, txtPhone.Text, txtEmail.Text);
                contact.Namn = txtName.Text;
                contact.Gatuadress = txtStreet.Text;
                contact.Postnummer = txtPstCode.Text;
                contact.Postort = txtCity.Text;
                contact.Telefon = txtPhone.Text;
                contact.Email = txtEmail.Text;
                people.Add(contact);

                stream.Write(contact.Namn + "," + contact.Gatuadress + "," + contact.Postnummer + "," + contact.Postort + "," + contact.Telefon + "," + contact.Email + "\n");
            }
        }
        void ListboxAdd()
        {
            lstBook.Items.Add(txtName.Text + "," + txtStreet.Text + "," + txtPstCode.Text + "," + txtCity.Text + "," + txtPhone.Text + "," + txtEmail.Text);
        }
        void ShowContact()
        {
            char c = ',';
            string contact = lstBook.SelectedItem.ToString();
            string[] conArr = contact.Split(c);

            lblName.Text = conArr[0];
            lblStreet.Text = conArr[1];
            lblPstCode.Text = conArr[2];
            lblCity.Text = conArr[3];
            lblPhone.Text = conArr[4];
            lblEmail.Text = conArr[5];
        }
        void DeleteLabels()
        {
            lblName.Text = "";
            lblStreet.Text = "";
            lblPstCode.Text = "";
            lblCity.Text = "";
            lblPhone.Text = "";
            lblEmail.Text = "";
        }
    }
}