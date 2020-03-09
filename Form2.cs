using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
    }
}
