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
using System.Threading.Tasks;

namespace sqlscanner2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\ARDA\source\repos\sqlscanner2\sqlscanner2\modül1.py");

            string strCmdText;
            strCmdText = @"python C:\Users\ARDA\source\repos\sqlscanner2\sqlscanner2\modül1.py";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);

            System.Threading.Thread.Sleep(0000);

            string url, ziak;
            url = textBox1.Text.ToString();
            ziak = textBox1.Text.ToString();
            label1.Text = String.Format("[#] {0} [#]",
                url);

            var path = @"C:\Users\ARDA\source\repos\sqlscanner2\sqlscanner2\targetsite.txt";
            File.WriteAllText(path, ziak);


            string txt;
            txt = @"C:\Users\ARDA\source\repos\sqlscanner2\sqlscanner2\sqlsite.txt";
    
            StreamReader streamReader = File.OpenText(@"C:\Users\ARDA\source\repos\sqlscanner2\sqlscanner2\sqlsite.txt");
            string metin;
            if ((metin = streamReader.ReadLine()) != null);
            {

                listBox1.Items.Add(metin);
            }
            streamReader.Close();
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
