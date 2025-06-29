using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;

namespace Lab1
{
    [Serializable]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Sydno> List = new List<Sydno>();
        private void Data_Click(object sender, EventArgs e)
        {
            List.Add(new Sydno { Name = "Pervui", Speed = 10, Crew = 5, Capacity = 1000 });
            List.Add(new Sydno("Vtorui", 20, 10, 2000));
            List.Add(new Sydno("Tretui", 30, 15, 3000));
            List.Add(new Sydno("Chetvertui", 40, 20, 4000));
            List.Add(new Sydno("Pyatui", 50, 25, 5000));
            for (int i= 0; i < List.Count; i++)
            {
                listBox1.Items.Add(List[i]);
            }

        }
        void SaveBinary(List<Sydno> List, string path)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (Stream fstream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binaryFormatter.Serialize(fstream, List);
            }
            listBox1.Items.Clear();
        }
        private void Binary_Click(object sender, EventArgs e)
        {
            string st = null;
            if (List.Count > 0)
            {
                OpenFileDialog open = new OpenFileDialog();
                if (open.ShowDialog() == DialogResult.OK)
                {
                    var path = open.FileName;
                    st = open.SafeFileName;
                    SaveBinary(List, path);
                }
            }
        }
        private void DeserializationBinary(string path)
        {
            
            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream stream = File.OpenRead(path))
            {

                var ListEnd = (List<Sydno>)formatter.Deserialize(stream);
                listBox1.Items.Clear();
                foreach (var items in ListEnd)
                {
                    listBox1.Items.Add(items.ToString());

                }
            }
        }
        void SaveXML(List<Sydno> list, string path)
        {
            using (Stream fstream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(List.GetType(), new Type[] { typeof(Sydno) });
                xmlSerializer.Serialize(fstream, List);
            }
            listBox1.Items.Clear();
        }
        private void XML_Click(object sender, EventArgs e)
        {
            string st = null;
            if (List.Count > 0)
            {
                OpenFileDialog open = new OpenFileDialog();
                if (open.ShowDialog() == DialogResult.OK)
                {
                    var path = open.FileName;
                    st = open.SafeFileName;
                    SaveXML(List, path);
                }
            }
        }
        private void DeserializationXML(string path)
        {
            var xmlFormat = new XmlSerializer(typeof(List<Sydno>));
            using (Stream stream = File.OpenRead(path))
            {
                var ListEnd = (List<Sydno>)xmlFormat.Deserialize(stream);
                listBox1.Items.Clear();
                foreach (var items in ListEnd)
                {
                    listBox1.Items.Add(items);
                }
            }
        }

        void SaveJSON(List<Sydno> List, string path)
        {
            DataContractJsonSerializer jsonFormat = new DataContractJsonSerializer(typeof(List<Sydno>));
            using (Stream fStream = new FileStream(path,
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                jsonFormat.WriteObject(fStream, List);
            }
            listBox1.Items.Clear();
        }
        private void JSON_Click(object sender, EventArgs e)
        {

            string st = null;
            if (List.Count > 0)
            {
                OpenFileDialog open = new OpenFileDialog();
                if (open.ShowDialog() == DialogResult.OK)
                {
                    var path = open.FileName;
                    st = open.SafeFileName;
                    SaveJSON(List, path);
                }
            }            
        }
        void DeserializationJSON(string path)
        {
            listBox1.Items.Clear();
            DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(List<Sydno>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            { 
                List<Sydno> deserilizeAn = (List<Sydno>)formatter.ReadObject(fs);
                if (deserilizeAn != null)
                {
                    foreach (var syd in deserilizeAn)
                    {
                        listBox1.Items.Add(syd);
                    }
                }
            }           
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog() == DialogResult.OK)
            {
                var path = open.FileName;
                DeserializationBinary(path);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                var path = open.FileName;
                DeserializationXML(path);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Sydno> ListEnd = new List<Sydno>();
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                var path = open.FileName;
                DeserializationJSON(path);

            }
        }
    }
}
