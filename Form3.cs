using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ESCPOS_NET;
using ESCPOS_NET.Emitters;
using ESCPOS_NET.Extensions;
using ESCPOS_NET.Utilities;
using Paranumeron.Properties;

namespace Paranumeron
{
	public partial class Form3 : Form
	{
		Dictionary<int, decimal[]> currencyrates;
		EPSON printer;
		SerialPrinter printerConn;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}
		public Form3()
		{
			InitializeComponent();
			kohatani.Enabled = true;
			string serialport = "COM1";
			string baudrate = "19200";
			printerConn = new SerialPrinter(portName: serialport, baudRate: int.Parse(baudrate));
			printer = new EPSON();
			currencyrates = new Dictionary<int, decimal[]>
			{
				{ 0, new decimal[] {1M, 1M} },
				{ 1, new decimal[] { 102.3M, 103.4M } },
				{ 2, new decimal[] { 121M, 121.3M } },
				{ 3, new decimal[] { 141.7M, 143.2M } },
				{ 4, new decimal[] { 112M, 112.9M } },
				{ 5, new decimal[] { 81M, 82.6M } },
				{ 6, new decimal[] { 74.7M, 76M } },
				{ 7, new decimal[] { 12.89M, 15.89M } },
				{ 8, new decimal[] { 69M, 0.94M } },
			};
			loadrates();
		}
		private XDocument CreateRecordDocument()
		{
			string recordpath = @"c:\temp\Historiku.xml";
			XDocument maindoc;
			// This text is added only once to the file.
			if (!File.Exists(recordpath))
			{
				// Create a file to write to.
				maindoc = new XDocument(
					new XElement("Conversions")
				);
			}
			else
			{
				maindoc = XDocument.Load(@"c:\temp\Historiku.xml");
			}
			return maindoc;
		}
		private void kohatani_Tick(object sender, EventArgs e)
		{
			string time = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
			this.koha.Text = time;
		}
		private void input_ValueChanged(object sender, EventArgs e)
		{
			var vlera = input.Value;
			int valutafrom;
			int valutato;
			if (currencyto.SelectedIndex > -1)
			{
				valutato = currencyto.SelectedIndex;
			}
			else
			{
				valutato = 0;
				currencyto.SelectedIndex = 0;
			}
			if (currencyfrom.SelectedIndex > -1)
			{
				valutafrom = currencyfrom.SelectedIndex;
			}
			else
			{
				valutafrom = 0;
				currencyfrom.SelectedIndex = 0;
			}
			decimal kursi = GjejKursin1(valutafrom);
			decimal kursi2 = GjejKursin2(valutato);
			ConvertCurrency(vlera, kursi2, kursi, valutafrom, valutato);
		}
		private void currency1_SelectedIndexChanged(object sender, EventArgs e)
		{
			var vlera = input.Value;
			int valutafrom;
			int valutato;
			if (currencyto.SelectedIndex > -1)
			{
				valutato = currencyto.SelectedIndex;
			}
			else
			{
				valutato = 0;
				currencyto.SelectedIndex = 0;
			}
			if (currencyfrom.SelectedIndex > -1)
			{
				valutafrom = currencyfrom.SelectedIndex;
			}
			else
			{
				valutafrom = 0;
				currencyfrom.SelectedIndex = 0;
			}
			decimal kursi = GjejKursin1(valutafrom);
			decimal kursi2 = GjejKursin2(valutato);
			ConvertCurrency(vlera, kursi2, kursi, valutafrom, valutato);
		}
		private void currency2_SelectedIndexChanged(object sender, EventArgs e)
		{
			var vlera = input.Value;
			int valutafrom;
			int valutato;
			if (currencyto.SelectedIndex > -1)
			{
				valutato = currencyto.SelectedIndex;
			}
			else
			{
				valutato = 0;
				currencyto.SelectedIndex = 0;
			}
			if (currencyfrom.SelectedIndex > -1)
			{
				valutafrom = currencyfrom.SelectedIndex;
			}
			else
			{
				valutafrom = 0;
				currencyfrom.SelectedIndex = 0;
			}
			decimal kursi = GjejKursin1(valutafrom);
			decimal kursi2 = GjejKursin2(valutato);
			ConvertCurrency(vlera, kursi2, kursi, valutafrom, valutato);
		}
		private bool CheckSameCurrency(int valutafrom, int valutato)
		{
			return int.Equals(valutafrom, valutato);
		}
		private void ConvertCurrency(decimal vlera, decimal kursi2, decimal kursi, int valutafrom, int valutato)
		{
			decimal finale;
			if (CheckSameCurrency(valutafrom, valutato))
			{
				finale = vlera;
			}
			else
			{
				finale = Math.Round(((vlera / kursi2) * kursi), 2);
			}
			string final = finale.ToString();
			this.converted.Text = final;
		}
		private decimal GjejKursin1(int valutafrom)
		{
			return currencyrates[valutafrom][0];
		}
		private decimal GjejKursin2(int valutato)
		{
			return currencyrates[valutato][1];
		}
		public void printo_Click(object sender, EventArgs e)
		{
			string sorttime = DateTime.Now.ToString("u");
			string printtime = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
			if (converted.Text != "Sasia")
			{
				bool islegacy = true;
				string paddednumber = Savefile.GetNumber();
				printerConn.Write(Print.Receipt(printer, islegacy, printtime, currencyfrom.Text, currencyto.Text, input.Value, converted.Text, paddednumber));
				Savefile.Main2(currencyfrom.Text, currencyto.Text, input.Value, sorttime, paddednumber);
				XElement xdoc = Savefile.CreateXMLTree(sorttime, currencyfrom.Text, currencyto.Text, input.Value, converted.Text, paddednumber);
				XDocument maindoc = CreateRecordDocument();
				maindoc.Root.AddFirst(new XElement(xdoc));
				maindoc.Save(@"c:\temp\Historiku.xml");
			}
			else
			{
				MessageBox.Show("Nuk mund te printohet fature boshe!");
			}
			Dispose(true);
		}
		private void button1_Click(object sender, EventArgs e)
		{
			GetLastReceipt();
		}
		public void GetLastReceipt()
		{
			bool islegacy = true;
			XDocument doc = XDocument.Load(@"c:\temp\cocktest2.xml");
			XElement root = doc.Root;
			XElement last = root.Element("Conversion");
			string koha = last.Attribute("datetime").Value;
			decimal amount = Convert.ToDecimal(last.Attribute("amount").Value);
			string currencyfrom = last.Attribute("currencyfrom").Value;
			string converted = last.Attribute("converted").Value;
			string currencyto = last.Attribute("currencyto").Value;
			string paddednumber = last.Attribute("Number").Value;
			printerConn.Write(Reprint.Receipt(printer, islegacy, koha, currencyfrom, currencyto, amount, converted, paddednumber));
		}
		private void button3_Click(object sender, EventArgs e)
		{
			Form4 history = new Form4();
			history.Visible = true;
		}
		public void loadrates()
		{

			XDocument doc = XDocument.Load(@"c:\temp\prices.xml");
			XElement root = doc.Root;
			XElement usd = root.Element("USD");
			decimal usdbuy = Convert.ToDecimal(usd.Attribute("buy").Value);
			decimal usdsell = Convert.ToDecimal(usd.Attribute("sell").Value);
			decimal[] usdprices = new decimal[2] { usdbuy, usdsell };
			XElement eur = root.Element("EUR");
			decimal eurbuy = Convert.ToDecimal(eur.Attribute("buy").Value);
			decimal eursell = Convert.ToDecimal(eur.Attribute("sell").Value);
			decimal[] eurprices = new decimal[2] { eurbuy, eursell };
			XElement gbp = root.Element("GBP");
			decimal gbpbuy = Convert.ToDecimal(gbp.Attribute("buy").Value);
			decimal gbpsell = Convert.ToDecimal(gbp.Attribute("sell").Value);
			decimal[] gbpprices = new decimal[2] { gbpbuy, gbpsell };
			XElement chf = root.Element("CHF");
			decimal chfbuy = Convert.ToDecimal(chf.Attribute("buy").Value);
			decimal chfsell = Convert.ToDecimal(chf.Attribute("sell").Value);
			decimal[] chfprices = new decimal[2] { chfbuy, chfsell };
			XElement cad = root.Element("CAD");
			decimal cadbuy = Convert.ToDecimal(cad.Attribute("buy").Value);
			decimal cadsell = Convert.ToDecimal(cad.Attribute("sell").Value);
			decimal[] cadprices = new decimal[2] { cadbuy, cadsell };
			XElement aud = root.Element("AUD");
			decimal audbuy = Convert.ToDecimal(aud.Attribute("buy").Value);
			decimal audsell = Convert.ToDecimal(aud.Attribute("sell").Value);
			decimal[] audprices = new decimal[2] { audbuy, audsell };
			XElement cny = root.Element("CNY");
			decimal cnybuy = Convert.ToDecimal(cny.Attribute("buy").Value);
			decimal cnysell = Convert.ToDecimal(cny.Attribute("sell").Value);
			decimal[] cnyprices = new decimal[2] { cnybuy, cnysell };
			XElement jpy = root.Element("JPY");
			decimal jpybuy = Convert.ToDecimal(jpy.Attribute("buy").Value);
			decimal jpysell = Convert.ToDecimal(jpy.Attribute("sell").Value);
			decimal[] jpyprices = new decimal[2] { jpybuy, jpysell };
			currencyrates[1] = usdprices;
			currencyrates[2] = eurprices;
			currencyrates[3] = gbpprices;
			currencyrates[4] = chfprices;
			currencyrates[5] = cadprices;
			currencyrates[6] = audprices;
			currencyrates[7] = cnyprices;
			currencyrates[8] = jpyprices;
		}
		class Savefile
		{
			public static string GetNumber()
			{
				string path = @"c:\temp\cocktest.txt";
				// This text is added only once to the file.
				if (!File.Exists(path))
				{
					// Create a file to write to.
					string createText = "1" + Environment.NewLine;
					File.WriteAllText(path, createText, Encoding.UTF8);
				}
				string fmt = "000000000.##";
				string number = File.ReadAllText(path);
				int newnumber = Convert.ToInt32(number) + 1;
				File.WriteAllText(path, newnumber.ToString());
				string paddednumber = newnumber.ToString(fmt);
				return paddednumber;
			}
			public static void Main2(string currencyfrom, string currencyto, decimal input, string koha, string newnumber)
			{
				string path = @"c:\temp\MyTest.txt";

				// This text is added only once to the file.
				if (!File.Exists(path))
				{
					// Create a file to write to.
					string createText = "Hello and Welcome" + Environment.NewLine;
					File.WriteAllText(path, createText, Encoding.UTF8);
				}

				string transaction = "\n" + newnumber + " " + koha + " " + input + " " + currencyfrom + " " + currencyto;
				File.AppendAllText(path, transaction, Encoding.UTF8);
			}

			public static XElement CreateXMLTree(string koha, string currencyfrom, string currencyto, decimal input, string converted, string paddednumber)
			{
				return new XElement("Conversion",
						new XAttribute("Number", paddednumber),
						new XAttribute("amount", input),
						new XAttribute("currencyfrom", currencyfrom),
						new XAttribute("converted", converted),
						new XAttribute("currencyto", currencyto),
						new XAttribute("datetime", koha)
				);
			}
		}

	}
}
