using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DGVPrinterHelper;
using System.Windows.Forms;

namespace Paranumeron
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        DataView dv;
        DataTable dt;
        private void Form4_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(@"c:\temp\cocktest2.xml");
            dataGridView1.DataSource = dataSet.Tables[0];
            dt = dataSet.Tables[0];
            dv = new DataView(dt);
        }

        private void loaddata()
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(@"c:\temp\cocktest2.xml");
            dataGridView1.DataSource = dataSet.Tables[0];
            DataTable dt = dataSet.Tables[0];
            DataView dv = new DataView(dt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "HISTORIKU I TRANSAKSIONEVE";
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "DANIEL TANKU TEST";
            printer.PrintDataGridView(dataGridView1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DateTime selecteddatefrom = dateTimePicker1.Value.Date;
            DateTime selecteddateto = dateTimePicker2.Value.Date.AddDays(1);
            if (selecteddatefrom == selecteddateto)
            {
                dv.RowFilter = String.Format("datetime > #{0:yyyy-MM-dd}#", selecteddatefrom); 
            }
            else
            {
                dv.RowFilter = String.Format("datetime >= #{0:yyyy-MM-dd}# AND datetime <= #{1:yyyy-MM-dd}#", selecteddatefrom, selecteddateto);
            }
            dataGridView1.DataSource = dv;
        }
    }
}
