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

namespace src
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ScanButton_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(textBox1.Text);
            Diagram objectDiagram = new Diagram(input);
            string[] lines = File.ReadAllLines("LogFile.txt");
            string buffer = "";
            foreach (var item in lines)
            {
                buffer = buffer + Environment.NewLine + item;
            }
            textBox2.Text = buffer;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
