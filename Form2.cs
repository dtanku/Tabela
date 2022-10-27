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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SetTheme();
        }
        public void SetTheme()
        {
            this.BackColor = Properties.Settings.Default.fcolor;
            this.clrvalues.BackColor = Properties.Settings.Default.fcolor;
            this.setvalues.BackColor = Properties.Settings.Default.fcolor;
            this.clrvalues.ForeColor = Properties.Settings.Default.bcolor;
            this.setvalues.ForeColor = Properties.Settings.Default.bcolor;
            this.shitje.ForeColor = Properties.Settings.Default.bcolor;
            this.blerje.ForeColor = Properties.Settings.Default.bcolor;
            this.valuta.ForeColor = Properties.Settings.Default.bcolor;
            this.dollar.ForeColor = Properties.Settings.Default.bcolor;
            this.euro.ForeColor = Properties.Settings.Default.bcolor;
            this.kanadez.ForeColor = Properties.Settings.Default.bcolor;
            this.pound.ForeColor = Properties.Settings.Default.bcolor;
            this.australian.ForeColor = Properties.Settings.Default.bcolor;
            this.yuan.ForeColor = Properties.Settings.Default.bcolor;
            this.yen.ForeColor = Properties.Settings.Default.bcolor;
            this.franga.ForeColor = Properties.Settings.Default.bcolor;
            this.usdbuy.ForeColor = Properties.Settings.Default.bcolor;
            this.usdbuy.BackColor = Properties.Settings.Default.fcolor;
            this.usdsell.ForeColor = Properties.Settings.Default.bcolor;
            this.usdsell.BackColor = Properties.Settings.Default.fcolor;
            this.eurbuy.ForeColor = Properties.Settings.Default.bcolor;
            this.eurbuy.BackColor = Properties.Settings.Default.fcolor;
            this.eursell.ForeColor = Properties.Settings.Default.bcolor;
            this.eursell.BackColor = Properties.Settings.Default.fcolor;
            this.gbpbuy.ForeColor = Properties.Settings.Default.bcolor;
            this.gbpbuy.BackColor = Properties.Settings.Default.fcolor;
            this.gbpsell.ForeColor = Properties.Settings.Default.bcolor;
            this.gbpsell.BackColor = Properties.Settings.Default.fcolor;
            this.cadbuy.ForeColor = Properties.Settings.Default.bcolor;
            this.cadbuy.BackColor = Properties.Settings.Default.fcolor;
            this.cadsell.ForeColor = Properties.Settings.Default.bcolor;
            this.cadsell.BackColor = Properties.Settings.Default.fcolor;
            this.chfbuy.ForeColor = Properties.Settings.Default.bcolor;
            this.chfbuy.BackColor = Properties.Settings.Default.fcolor;
            this.chfsell.ForeColor = Properties.Settings.Default.bcolor;
            this.chfsell.BackColor = Properties.Settings.Default.fcolor;
            this.audbuy.ForeColor = Properties.Settings.Default.bcolor;
            this.audbuy.BackColor = Properties.Settings.Default.fcolor;
            this.audsell.ForeColor = Properties.Settings.Default.bcolor;
            this.audsell.BackColor = Properties.Settings.Default.fcolor;
            this.cnybuy.ForeColor = Properties.Settings.Default.bcolor;
            this.cnybuy.BackColor = Properties.Settings.Default.fcolor;
            this.cnysell.ForeColor = Properties.Settings.Default.bcolor;
            this.cnysell.BackColor = Properties.Settings.Default.fcolor;
            this.jpybuy.ForeColor = Properties.Settings.Default.bcolor;
            this.jpybuy.BackColor = Properties.Settings.Default.fcolor;
            this.jpysell.ForeColor = Properties.Settings.Default.bcolor;
            this.jpysell.BackColor = Properties.Settings.Default.fcolor;
        }
        public string usdblej
        {
            get { return usdbuy.Text; }
        }
        public string usdshes
        {
            get { return usdsell.Text; }
        }
        public string eurblej
        {
            get { return eurbuy.Text; }
        }
        public string eurshes
        {
            get { return eursell.Text; }
        }
        public string gbpblej
        {
            get { return gbpbuy.Text; }
        }
        public string gbpshes
        {
            get { return gbpsell.Text; }
        }
        public string chfblej
        {
            get { return chfbuy.Text; }
        }
        public string chfshes
        {
            get { return chfsell.Text; }
        }
        public string cadblej
        {
            get { return cadbuy.Text; }
        }
        public string cadshes
        {
            get { return cadsell.Text; }
        }
        public string audblej
        {
            get { return audbuy.Text; }
        }
        public string audshes
        {
            get { return audsell.Text; }
        }
        public string cnyblej
        {
            get { return cnybuy.Text; }
        }
        public string cnyshes
        {
            get { return cnysell.Text; }
        }
        public string jpyblej
        {
            get { return jpybuy.Text; }
        }
        public string jpyshes
        {
            get { return jpysell.Text; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            usdbuy.Text = String.Empty;
            eurbuy.Text = String.Empty;
            gbpbuy.Text = String.Empty;
            chfbuy.Text = String.Empty;
            cadbuy.Text = String.Empty;
            audbuy.Text = String.Empty;
            cnybuy.Text = String.Empty;
            jpybuy.Text = String.Empty;
            usdsell.Text = String.Empty;
            eursell.Text = String.Empty;
            gbpsell.Text = String.Empty;
            chfsell.Text = String.Empty;
            cadsell.Text = String.Empty;
            audsell.Text = String.Empty;
            cnysell.Text = String.Empty;
            jpysell.Text = String.Empty;
        }
    }
}
