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
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
namespace ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Person> pers = new List<Person>();
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void addbutt_Click(object sender, EventArgs e)
        {
            Person p = new Person();

            personsListView editForm = new personsListView(p);
            if (editForm.ShowDialog() != DialogResult.OK)
                return;
            pers.Add(p);
            listView1.VirtualListSize = pers.Count;
            listView1.Invalidate();


            if (editForm.ShowDialog() != DialogResult.OK)
               
            return;
            ListViewItem newItem =
            listView1.Items.Add(editForm.FirstName);
            newItem.SubItems.Add(editForm.LastName);
            newItem.SubItems.Add(editForm.Age.ToString());


        }

        private void redactbutt_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 0)
                return;
            Person p = pers[listView1.SelectedIndices[0]];
            personsListView editForm = new personsListView(p);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                listView1.Invalidate();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            try
            {
                using (FileStream fStream = new FileStream("AllMyPerson.dat",
                FileMode.OpenOrCreate, FileAccess.Read, FileShare.None))
                {
                    pers.AddRange((List<Person>)binFormat.Deserialize(fStream));
                }
            }
            catch
            { } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Person item in pers)
            {
                sb.Append("Сотрудник: \n" + item.ToString());
            }
            richTextBox1.Text = sb.ToString();
        }

        private void listView1_RetrieveVirtualItem_1(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (e.ItemIndex >= 0 && e.ItemIndex < pers.Count)
            {
                e.Item = new ListViewItem(pers[e.ItemIndex].FirstName);
                e.Item.SubItems.Add(pers[e.ItemIndex].LastName);
                e.Item.SubItems.Add(pers[e.ItemIndex].Age.ToString());
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (FileStream fStream = new FileStream("AllMyPerson.dat",
            FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, pers);
            }

            using (FileStream fStream = new FileStream("PersonCollection.xml",
FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer xmlFormat = new
                XmlSerializer(typeof(List<Person>));
                xmlFormat.Serialize(fStream, pers);
            }
        }
    }
}
