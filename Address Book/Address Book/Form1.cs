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
using System.Xml;

namespace Address_Book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Person> people = new List<Person>();
        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            if (!Directory.Exists(path + "\\Address Book- Spasina"))
            {
                Directory.CreateDirectory(path + "\\Address Book- Spasina");
            }
            if (!File.Exists(path + "\\Address Book- Spasina\\settings.xml"))
            {
                XmlTextWriter xW = new XmlTextWriter(path + "\\Address Book- Spasina\\settings.xml", Encoding.UTF8);
                xW.WriteStartElement ("People");
                xW.WriteEndElement();
                xW.Close();
            }
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path + "\\Address Book- Spasina\\settings.xml");
            foreach(XmlNode xn in xDoc.SelectNodes("People/Person"))
            {
                Person p = new Person();
                p.Name = xn.SelectSingleNode("Name").InnerText;
                p.Email = xn.SelectSingleNode("Email").InnerText;
                p.StreetAddress = xn.SelectSingleNode("Address").InnerText;
                p.AddItToNotes = xn.SelectSingleNode("Notes").InnerText;
                p.Birthday = DateTime.FromFileTime(Convert.ToInt64(xn.SelectSingleNode("Birthday").InnerText));
                people.Add(p);
                listView1.Items.Add(p.Name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Name = textBox1.Text;
            p.Email = textBox2.Text;
            p.StreetAddress = textBox3.Text;
            p.Birthday = dateTimePicker1.Value;
            p.AddItToNotes = textBox4.Text;
            people.Add(p);
            listView1.Items.Add(p.Name);
            listView1.View = View.List;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Value = DateTime.Now;

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            textBox1.Text = people[listView1.SelectedItems[0].Index].Name;
            textBox2.Text = people[listView1.SelectedItems[0].Index].Email;
            textBox3.Text = people[listView1.SelectedItems[0].Index].StreetAddress;
            textBox4.Text = people[listView1.SelectedItems[0].Index].AddItToNotes;
            dateTimePicker1.Value = people[listView1.SelectedItems[0].Index].Birthday;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Remove();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }
        void Remove()
        {
            try
            {
                people.RemoveAt((int)listView1.SelectedItems[0].Index);
                listView1.Items.Remove(listView1.SelectedItems[0]);

            }
            catch { }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            people[listView1.SelectedItems[0].Index].Name = textBox1.Text;
            people[listView1.SelectedItems[0].Index].Email = textBox2.Text;
            people[listView1.SelectedItems[0].Index].StreetAddress = textBox3.Text;
            people[listView1.SelectedItems[0].Index].Birthday = dateTimePicker1.Value;
            people[listView1.SelectedItems[0].Index].AddItToNotes = textBox4.Text;
            listView1.SelectedItems[0].Text = textBox1.Text;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            xDoc.Load(path + "\\Address Book- Spasina");
            XmlNode xn = xDoc.SelectSingleNode("People");
            xn.RemoveAll();
            foreach (Person p in people)
            {
                XmlNode xTop = xDoc.CreateElement("Person");
                XmlNode xName= xDoc.CreateElement("Name");
                XmlNode xEmail= xDoc.CreateElement("Email");
                XmlNode xAddress= xDoc.CreateElement("Address");
                XmlNode xBirthday= xDoc.CreateElement("Birthday");
                XmlNode xNotes= xDoc.CreateElement("Notes");
                xName.InnerText = p.Name;
                xEmail.InnerText = p.Email;
                xAddress.InnerText = p.StreetAddress;
                xBirthday.InnerText = p.Birthday.ToFileTime().ToString();
                xNotes.InnerText = p.AddItToNotes;
                xTop.AppendChild(xName);
                xTop.AppendChild(xEmail);
                xTop.AppendChild(xAddress);
                xTop.AppendChild(xBirthday);
                xTop.AppendChild(xNotes);
                xDoc.DocumentElement.AppendChild(xTop);
            }
            xDoc.Save(path + "\\Address Book- Spasina");
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string StreetAddress { get; set; }
        public string AddItToNotes { get; set; }
        public DateTime Birthday { get; set; }
    }
}
