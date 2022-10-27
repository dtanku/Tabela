using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using ESCPOS_NET.Emitters;

namespace Paranumeron
{
    class Print
    {
		public static byte[][] Receipt(ICommandEmitter printeri, bool isLegacy, string koha, string currencyfrom, string currencyto, decimal input, string converted, string paddednumber) => new byte[][]
		{
			printeri.LeftAlign(),
			printeri.SetBarcodeHeightInDots(360),
			printeri.SetBarWidth(BarWidth.Default),
			printeri.SetBarLabelPosition(BarLabelPrintPosition.Below),
			printeri.PrintImage(File.ReadAllBytes("Resources/paranumeron100.png"), true, isLegacy),
			printeri.LeftAlign(),
			printeri.PrintLine("DANIEL TANKU"),
			printeri.PrintLine("TIRANA, PRINT TEST"),
			printeri.PrintLine("TOP SECRET PROGRAM FEATURE"),
			printeri.SetStyles(PrintStyle.Underline),
			printeri.PrintLine("Konvertimi i monedhes"),
			printeri.SetStyles(PrintStyle.None),
			printeri.PrintLine(""),
			printeri.LeftAlign(),
			printeri.PrintLine("Fatura Nr.: " + paddednumber +"       " + koha),
			printeri.SetStyles(PrintStyle.FontB),
			printeri.PrintLine("----------------------------------------------------------------"),
			printeri.Print2DCode(TwoDimensionCodeType.PDF417, "Fatura " + paddednumber + ": " + koha + ", " + input + " " + currencyfrom + " = " + converted + " " + currencyto, Size2DCode.SMALL),
			printeri.PrintLine("----------------------------------------------------------------"),
			printeri.SetStyles(PrintStyle.None),
			printeri.LeftAlign(),
			printeri.PrintLine("JU KENI KONVERTUAR " + input + " " + currencyfrom),
			printeri.PrintLine("KENI MARRE         " + converted + " " + currencyto),
			printeri.PrintLine("KURSI ESHTE: 1 " + currencyfrom + " = " + Math.Round(Convert.ToDecimal(converted) / input, 3) + " " + currencyto),
			printeri.RightAlign(),
			printeri.PrintLine(""),
			printeri.FullCutAfterFeed(5)
		};
    }
}
