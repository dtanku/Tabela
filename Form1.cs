using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.IO.Ports;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Paranumeron
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public void Form1_Load(object sender, EventArgs e)
		{
			HtmlWeb web = new HtmlWeb();
			web.UsingCache = false;
			timenow.Enabled = true;
			setfont18();
			setTheme();
		}
		private void SetData()
		{
			int timeoutInMilliseconds = 2000;
			// Load webpage, conversion rates,, sset refresh
			Console.WriteLine("celiD");
			var uri = new Uri("http://iliria98.com");
			var doc = Supremes.Dcsoup.Parse(uri, timeoutInMilliseconds);
			valuerefresh.Enabled = true;
			string[] xcrates = new string[16];

			// Pull main table
			var maindiv = doc.Select("div.left");
			var divtwo = doc.Select("div.rates");
			var tabela = doc.Select("div.overflow");

			// Pull each currency columns, buy, sell, convert to float
			var usd = tabela.Select("div[rate=2]");
			var pullusdbuy = usd.Select("span:eq(1)");
			var pullusdsell = usd.Select("span:eq(2)");
			float usdbuy = float.Parse(pullusdbuy.Text);
			float usdsell = float.Parse(pullusdsell.Text);
			var eur = tabela.Select("div[rate=3]");
			var pulleurbuy = eur.Select("span:eq(1)");
			var pulleursell = eur.Select("span:eq(2)");
			float eurbuy = float.Parse(pulleurbuy.Text);
			float eursell = float.Parse(pulleursell.Text);
			var gbp = tabela.Select("div[rate=5]");
			var pullgbpbuy = gbp.Select("span:eq(1)");
			var pullgbpsell = gbp.Select("span:eq(2)");
			float gbpbuy = float.Parse(pullgbpbuy.Text);
			float gbpsell = float.Parse(pullgbpsell.Text);
			var chf = tabela.Select("div[rate=4]");
			var pullchfbuy = chf.Select("span:eq(1)");
			var pullchfsell = chf.Select("span:eq(2)");
			float chfbuy = float.Parse(pullchfbuy.Text);
			float chfsell = float.Parse(pullchfsell.Text);
			var aud = tabela.Select("div[rate=10]");
			var pullaudbuy = aud.Select("span:eq(1)");
			var pullaudsell = aud.Select("span:eq(2)");
			float audbuy = float.Parse(pullaudbuy.Text);
			float audsell = float.Parse(pullaudsell.Text);
			var cad = tabela.Select("div[rate=9]");
			var pullcadbuy = cad.Select("span:eq(1)");
			var pullcadsell = cad.Select("span:eq(2)");
			float cadbuy = float.Parse(pullcadbuy.Text);
			float cadsell = float.Parse(pullcadsell.Text);
			var cny = tabela.Select("div[rate=106]");
			var pullcnybuy = cny.Select("span:eq(1)");
			var pullcnysell = cny.Select("span:eq(2)");
			float cnybuy = float.Parse(pullcnybuy.Text);
			float cnysell = float.Parse(pullcnysell.Text);
			var jpy = tabela.Select("div[rate=11]");
			var pulljpybuy = jpy.Select("span:eq(1)");
			var pulljpysell = jpy.Select("span:eq(2)");
			float jpybuy = float.Parse(pulljpybuy.Text);
			float jpysell  = float.Parse(pulljpysell.Text);

			//Set array contents to exchange rates
			xcrates[0] = usdbuy.ToString();
			xcrates[1] = usdsell.ToString();
			xcrates[2] = eurbuy.ToString();
			xcrates[3] = eursell.ToString();
			xcrates[4] = gbpbuy.ToString();
			xcrates[5] = gbpsell.ToString();
			xcrates[6] = chfbuy.ToString();
			xcrates[7] = chfsell.ToString();
			xcrates[8] = cadbuy.ToString();
			xcrates[9] = cadsell.ToString();
			xcrates[10] = audbuy.ToString();
			xcrates[11] = audsell.ToString();
			xcrates[12] = cnybuy.ToString();
			xcrates[13] = cnysell.ToString();
			xcrates[14] = jpybuy.ToString();
			xcrates[15] = jpysell.ToString();

			// Sets textbox contents to exhange rates 
			usdbli.Text = xcrates[0];
			usdshit.Text = xcrates[1];
			eurbli.Text = xcrates[2];
			eurshit.Text = xcrates[3];
			gbpbli.Text = xcrates[4];
			gbpshit.Text = xcrates[5];
			chfbli.Text = xcrates[6];
			chfshit.Text = xcrates[7];
			cadbli.Text = xcrates[8];
			cadshit.Text = xcrates[9];
			audbli.Text = xcrates[10];
			audshit.Text = xcrates[11];
			cnybli.Text = xcrates[12];
			cnyshit.Text = xcrates[13];
			jpybli.Text = xcrates[14];
			jpyshit.Text = xcrates[15];

			// Sets rates to XML
			CreateXMLTree(xcrates);
		}
		private void timenow_Tick(object sender, EventArgs e)
		{
			this.time.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
		}
		private void valuerefresh_Tick(object sender, EventArgs e)
		{

		}
		private void logo_Click(object sender, EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.Sizable;
			this.WindowState = FormWindowState.Normal;
			this.menuStrip1.Visible = true;
		}
		private void enableToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.tabela.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
		}
		private void disableToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.tabela.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
		}
		private void fullscreenToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.None;
			this.WindowState = FormWindowState.Maximized;
			this.menuStrip1.Visible = false;
		}
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams cp = base.CreateParams;
				cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
				return cp;
			}
		}
		private void setfont18()
		{
			usd.Font = new Font(usd.Font.FontFamily, 18, FontStyle.Bold);
			usdbli.Font = new Font(usdbli.Font.FontFamily, 18, FontStyle.Bold);
			usdshit.Font = new Font(usdshit.Font.FontFamily, 18, FontStyle.Bold);
			eur.Font = new Font(eur.Font.FontFamily, 18, FontStyle.Bold);
			eurbli.Font = new Font(eurbli.Font.FontFamily, 18, FontStyle.Bold);
			eurshit.Font = new Font(eurbli.Font.FontFamily, 18, FontStyle.Bold);
			gbp.Font = new Font(gbp.Font.FontFamily, 18, FontStyle.Bold);
			gbpbli.Font = new Font(gbpbli.Font.FontFamily, 18, FontStyle.Bold);
			gbpshit.Font = new Font(gbpshit.Font.FontFamily, 18, FontStyle.Bold);
			chf.Font = new Font(chf.Font.FontFamily, 18, FontStyle.Bold);
			chfbli.Font = new Font(chfbli.Font.FontFamily, 18, FontStyle.Bold);
			chfshit.Font = new Font(chfshit.Font.FontFamily, 18, FontStyle.Bold);
			cad.Font = new Font(cad.Font.FontFamily, 18, FontStyle.Bold);
			cadbli.Font = new Font(cadbli.Font.FontFamily, 18, FontStyle.Bold);
			cadshit.Font = new Font(cadshit.Font.FontFamily, 18, FontStyle.Bold);
			aud.Font = new Font(aud.Font.FontFamily, 18, FontStyle.Bold);
			audbli.Font = new Font(audbli.Font.FontFamily, 18, FontStyle.Bold);
			audshit.Font = new Font(audshit.Font.FontFamily, 18, FontStyle.Bold);
			cny.Font = new Font(cny.Font.FontFamily, 18, FontStyle.Bold);
			cnybli.Font = new Font(cnybli.Font.FontFamily, 18, FontStyle.Bold);
			cnyshit.Font = new Font(cnyshit.Font.FontFamily, 18, FontStyle.Bold);
			jpy.Font = new Font(jpy.Font.FontFamily, 18, FontStyle.Bold);
			jpybli.Font = new Font(jpybli.Font.FontFamily, 18, FontStyle.Bold);
			jpyshit.Font = new Font(jpyshit.Font.FontFamily, 18, FontStyle.Bold);
			valuta.Font = new Font(valuta.Font.FontFamily, 18, FontStyle.Bold);
			blerje.Font = new Font(blerje.Font.FontFamily, 18, FontStyle.Bold);
			shitje.Font = new Font(shitje.Font.FontFamily, 18, FontStyle.Bold);

		}
		private void setfont28()
		{
			usd.Font = new Font(usd.Font.FontFamily, 28, FontStyle.Bold);
			usdbli.Font = new Font(usdbli.Font.FontFamily, 28, FontStyle.Bold);
			usdshit.Font = new Font(usdshit.Font.FontFamily, 28, FontStyle.Bold);
			eur.Font = new Font(eur.Font.FontFamily, 28, FontStyle.Bold);
			eurbli.Font = new Font(eurbli.Font.FontFamily, 28, FontStyle.Bold);
			eurshit.Font = new Font(eurbli.Font.FontFamily, 28, FontStyle.Bold);
			gbp.Font = new Font(gbp.Font.FontFamily, 28, FontStyle.Bold);
			gbpbli.Font = new Font(gbpbli.Font.FontFamily, 28, FontStyle.Bold);
			gbpshit.Font = new Font(gbpshit.Font.FontFamily, 28, FontStyle.Bold);
			chf.Font = new Font(chf.Font.FontFamily, 28, FontStyle.Bold);
			chfbli.Font = new Font(chfbli.Font.FontFamily, 28, FontStyle.Bold);
			chfshit.Font = new Font(chfshit.Font.FontFamily, 28, FontStyle.Bold);
			cad.Font = new Font(cad.Font.FontFamily, 28, FontStyle.Bold);
			cadbli.Font = new Font(cadbli.Font.FontFamily, 28, FontStyle.Bold);
			cadshit.Font = new Font(cadshit.Font.FontFamily, 28, FontStyle.Bold);
			aud.Font = new Font(aud.Font.FontFamily, 28, FontStyle.Bold);
			audbli.Font = new Font(audbli.Font.FontFamily, 28, FontStyle.Bold);
			audshit.Font = new Font(audshit.Font.FontFamily, 28, FontStyle.Bold);
			cny.Font = new Font(cny.Font.FontFamily, 28, FontStyle.Bold);
			cnybli.Font = new Font(cnybli.Font.FontFamily, 28, FontStyle.Bold);
			cnyshit.Font = new Font(cnyshit.Font.FontFamily, 28, FontStyle.Bold);
			jpy.Font = new Font(jpy.Font.FontFamily, 28, FontStyle.Bold);
			jpybli.Font = new Font(jpybli.Font.FontFamily, 28, FontStyle.Bold);
			jpyshit.Font = new Font(jpyshit.Font.FontFamily, 28, FontStyle.Bold);
			valuta.Font = new Font(valuta.Font.FontFamily, 28, FontStyle.Bold);
			blerje.Font = new Font(blerje.Font.FontFamily, 28, FontStyle.Bold);
			shitje.Font = new Font(shitje.Font.FontFamily, 28, FontStyle.Bold);
		}
		private void setfont56() {
			usd.Font = new Font(usd.Font.FontFamily, 56, FontStyle.Bold);
			usdbli.Font = new Font(usdbli.Font.FontFamily, 56, FontStyle.Bold);
			usdshit.Font = new Font(usdshit.Font.FontFamily, 56, FontStyle.Bold);
			eur.Font = new Font(eur.Font.FontFamily, 56, FontStyle.Bold);
			eurbli.Font = new Font(eurbli.Font.FontFamily, 56, FontStyle.Bold);
			eurshit.Font = new Font(eurbli.Font.FontFamily, 56, FontStyle.Bold);
			gbp.Font = new Font(gbp.Font.FontFamily, 56, FontStyle.Bold);
			gbpbli.Font = new Font(gbpbli.Font.FontFamily, 56, FontStyle.Bold);
			gbpshit.Font = new Font(gbpshit.Font.FontFamily, 56, FontStyle.Bold);
			chf.Font = new Font(chf.Font.FontFamily, 56, FontStyle.Bold);
			chfbli.Font = new Font(chfbli.Font.FontFamily, 56, FontStyle.Bold);
			chfshit.Font = new Font(chfshit.Font.FontFamily, 56, FontStyle.Bold);
			cad.Font = new Font(cad.Font.FontFamily, 56, FontStyle.Bold);
			cadbli.Font = new Font(cadbli.Font.FontFamily, 56, FontStyle.Bold);
			cadshit.Font = new Font(cadshit.Font.FontFamily, 56, FontStyle.Bold);
			aud.Font = new Font(aud.Font.FontFamily, 56, FontStyle.Bold);
			audbli.Font = new Font(audbli.Font.FontFamily, 56, FontStyle.Bold);
			audshit.Font = new Font(audshit.Font.FontFamily, 56, FontStyle.Bold);
			cny.Font = new Font(cny.Font.FontFamily, 56, FontStyle.Bold);
			cnybli.Font = new Font(cnybli.Font.FontFamily, 56, FontStyle.Bold);
			cnyshit.Font = new Font(cnyshit.Font.FontFamily, 56, FontStyle.Bold);
			jpy.Font = new Font(jpy.Font.FontFamily, 56, FontStyle.Bold);
			jpybli.Font = new Font(jpybli.Font.FontFamily, 56, FontStyle.Bold);
			jpyshit.Font = new Font(jpyshit.Font.FontFamily, 56, FontStyle.Bold);
			valuta.Font = new Font(valuta.Font.FontFamily, 56, FontStyle.Bold);
			blerje.Font = new Font(blerje.Font.FontFamily, 56, FontStyle.Bold);
			shitje.Font = new Font(shitje.Font.FontFamily, 56, FontStyle.Bold);
		}
		private void setTheme()
        {
			time.ForeColor = Properties.Settings.Default.bcolor;
			paranumeron.Text = Properties.Settings.Default.company;
			paranumeron.ForeColor = Properties.Settings.Default.bcolor;
			this.BackColor = Properties.Settings.Default.fcolor;
			usd.ForeColor = Properties.Settings.Default.bcolor;
			usdbli.ForeColor = Properties.Settings.Default.bcolor;
			usdshit.ForeColor = Properties.Settings.Default.bcolor;
			eur.ForeColor = Properties.Settings.Default.bcolor;
			eurbli.ForeColor = Properties.Settings.Default.bcolor;
			eurshit.ForeColor = Properties.Settings.Default.bcolor;
			gbp.ForeColor = Properties.Settings.Default.bcolor;
			gbpbli.ForeColor = Properties.Settings.Default.bcolor;
			gbpshit.ForeColor = Properties.Settings.Default.bcolor;
			chf.ForeColor = Properties.Settings.Default.bcolor;
			chfbli.ForeColor = Properties.Settings.Default.bcolor;
			chfshit.ForeColor = Properties.Settings.Default.bcolor;
			cad.ForeColor = Properties.Settings.Default.bcolor;
			cadbli.ForeColor = Properties.Settings.Default.bcolor;
			cadshit.ForeColor = Properties.Settings.Default.bcolor;
			aud.ForeColor = Properties.Settings.Default.bcolor;
			audbli.ForeColor = Properties.Settings.Default.bcolor;
			audshit.ForeColor = Properties.Settings.Default.bcolor;
			cny.ForeColor = Properties.Settings.Default.bcolor;
			cnybli.ForeColor = Properties.Settings.Default.bcolor;
			cnyshit.ForeColor = Properties.Settings.Default.bcolor;
			jpy.ForeColor = Properties.Settings.Default.bcolor;
			jpybli.ForeColor = Properties.Settings.Default.bcolor;
			jpyshit.ForeColor = Properties.Settings.Default.bcolor;
			valuta.ForeColor = Properties.Settings.Default.bcolor;
			blerje.ForeColor = Properties.Settings.Default.bcolor;
			shitje.ForeColor = Properties.Settings.Default.bcolor;
		}
		private void smallToolStripMenuItem_Click(object sender, EventArgs e)
		{
			setfont18();
		}
		private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
		{
			setfont28();
		}
		private void largeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			setfont56();
		}
		private void manualOfflineToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (Form2 setvalueform = new Form2())
			{
				string[] xcrates = new string[16];
				if (setvalueform.ShowDialog() == DialogResult.OK)
				{
					// set textbox contents to exchange rates
					usdbli.Text = setvalueform.usdblej;
					eurbli.Text = setvalueform.eurblej;
					gbpbli.Text = setvalueform.gbpblej;
					chfbli.Text = setvalueform.chfblej;
					cadbli.Text = setvalueform.cadblej;
					audbli.Text = setvalueform.audblej;
					cnybli.Text = setvalueform.cnyblej;
					jpybli.Text = setvalueform.jpyblej;
					usdshit.Text = setvalueform.usdshes;
					eurshit.Text = setvalueform.eurshes;
					gbpshit.Text = setvalueform.gbpshes;
					chfshit.Text = setvalueform.chfshes;
					cadshit.Text = setvalueform.cadshes;
					audshit.Text = setvalueform.audshes;
					cnyshit.Text = setvalueform.cnyshes;
					jpyshit.Text = setvalueform.jpyshes;

					// set array values to exchange rates
					xcrates[0] = setvalueform.usdblej;
					xcrates[1] = setvalueform.eurblej;
					xcrates[2] = setvalueform.gbpblej;
					xcrates[3] = setvalueform.chfblej;
					xcrates[4] = setvalueform.cadblej;
					xcrates[5] = setvalueform.audblej;
					xcrates[6] = setvalueform.cnyblej;
					xcrates[7] = setvalueform.jpyblej;
					xcrates[8] = setvalueform.usdshes;
					xcrates[9] = setvalueform.eurshes;
					xcrates[10] = setvalueform.gbpshes;
					xcrates[11] = setvalueform.chfshes;
					xcrates[12] = setvalueform.cadshes;
					xcrates[13] = setvalueform.audshes;
					xcrates[14] = setvalueform.cnyshes;
					xcrates[15] = setvalueform.jpyshes;
					CreateXMLTree(xcrates);
				}
			}
			valuerefresh.Enabled = false;
		}
		private void automaticOnlineToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SetData();
		}
		public static void CreateXMLTree(string[] xcrates)
		{
			XDocument maindoc = CreateRecordDocument();
			XElement parent = maindoc.Element("Root");

			XElement xdoc = new XElement("Root",
					new XElement("USD",
						new XAttribute("buy", xcrates[0]),
						new XAttribute("sell", xcrates[8])),
					new XElement("EUR",  
						new XAttribute("buy", xcrates[1]),
						new XAttribute("sell", xcrates[9])),
					new XElement("GBP",
						new XAttribute("buy", xcrates[2]),
						new XAttribute("sell", xcrates[10])),
					new XElement("CHF",
						new XAttribute("buy", xcrates[3]),
						new XAttribute("sell", xcrates[11])),
					new XElement("CAD",
						new XAttribute("buy", xcrates[4]),
						new XAttribute("sell", xcrates[12])),
					new XElement("AUD",
						new XAttribute("buy", xcrates[5]),
						new XAttribute("sell", xcrates[13])),
					new XElement("CNY",
						new XAttribute("buy", xcrates[6]),
						new XAttribute("sell", xcrates[14])),
					new XElement("JPY",
						new XAttribute("buy", xcrates[7]),
						new XAttribute("sell", xcrates[15]))
			);

			parent.ReplaceWith(new XElement(xdoc));
			maindoc.Save(@"E:\repos\prices.xml");
		}
		public static XDocument CreateRecordDocument()
		{
			string recordpath = @"E:\repos\prices.xml";
			XDocument maindoc;
			// This text is added only once to the file.
			if (!File.Exists(recordpath))
			{
				// Create a file to write to.
				maindoc = new XDocument(
					new XElement("Prices")
				);
			}
			else
			{
				maindoc = XDocument.Load(@"E:\repos\prices.xml");
			}
			return maindoc;
		}

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
			Form5 settings = new Form5() { Visible = true };
        }
        //		private void convertToolStripMenuItem_Click(object sender, EventArgs e)
        //		{
        //			Form3 convertform = new Form3();
        //			convertform.Visible = true;
        //		}
    }
}
