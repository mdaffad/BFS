using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace src
{
    public partial class Form1 : Form
    {
        private IconButton currentBtn;
        private Panel bottomBorder;
        private Form currentPage;

        public Form1()
        {
            InitializeComponent();
            bottomBorder = new Panel();
            bottomBorder.Size = new Size(200, 3);
            panelMenu.Controls.Add(bottomBorder);
            OpenPage(new Form3());
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(236, 80, 115);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(49, 159, 232);

        }

        private void ActivateButton(object sender, Color color)
        {
            if (sender != null)
            {
                DisableButton();

                currentBtn = (IconButton)sender;
                currentBtn.BackColor = Color.FromArgb(47, 23, 69);
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;

                bottomBorder.BackColor = color;
                bottomBorder.Location = new Point(0, currentBtn.Location.Y + 60);
                bottomBorder.Visible = true;
                bottomBorder.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(17, 1, 31);
                currentBtn.ForeColor = Color.SeaShell;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.SeaShell;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenPage(Form page)
        {
            if (currentPage != null)
            {
                currentPage.Close();
            }
            currentPage = page;
            currentPage.TopLevel = false;
            currentPage.FormBorderStyle = FormBorderStyle.None;
            currentPage.Dock = DockStyle.Fill;
            panel5.Controls.Add(currentPage);
            panel5.Tag = currentPage;
            currentPage.BringToFront();
            currentPage.Show();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenPage(new Form3());
        }

        private void GraphButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenPage(new Form2());
        }

        private void ContactButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenPage(new Form4());
        }

        private void HMIF_Click(object sender, EventArgs e)
        {
            currentPage.Close();
            Reset();
            OpenPage(new Form3());
        }

        private void Reset()
        {
            DisableButton();
            bottomBorder.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clock.Text = DateTime.Now.ToLongTimeString();
            Date.Text = DateTime.Now.ToLongDateString();
        }

    }
}
