using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paranumeron
{
    public partial class Form5 : Form
    {
        Color fcolor;
        Color bcolor;
        public Form5()
        {
            InitializeComponent();
            SetTheme();
            companyname.Text = Properties.Settings.Default.company;
            colorDialog1.Color = Properties.Settings.Default.fcolor;
            fcolor = Properties.Settings.Default.fcolor;
            colorDialog2.Color = Properties.Settings.Default.bcolor;
            bcolor = Properties.Settings.Default.bcolor;
        }
        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.company = companyname.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Fusni emrin e kompanisë!");
            }
            Properties.Settings.Default.fcolor = fcolor;
            Properties.Settings.Default.bcolor = bcolor;
            Properties.Settings.Default.Save();
            Application.Restart();
            Environment.Exit(0);
        }
        public void SetTheme()
        {
            this.BackColor = Properties.Settings.Default.fcolor;
            this.company.ForeColor = Properties.Settings.Default.bcolor;
            this.label1.ForeColor = Properties.Settings.Default.bcolor;
            this.label2.ForeColor = Properties.Settings.Default.bcolor;
            this.save.ForeColor = Properties.Settings.Default.bcolor;
        }
        private void fcolorbutton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            DialogResult result = colorDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                fcolor = colorDialog1.Color;
            }
        }

        private void bcolorbutton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog2 = new ColorDialog();
            DialogResult result = colorDialog2.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                bcolor = colorDialog2.Color;
            }
        }
    }
}
