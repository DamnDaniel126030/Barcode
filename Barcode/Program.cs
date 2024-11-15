using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Barcode
{
	internal class Program
	{
		static void Main(string[] args)
		{
			BarcodeNumbersToFile barcodeGenerate = new BarcodeNumbersToFile(7, "barcodes.txt");
			barcodeGenerate.StartGenerating();
			//GenerateBarcodeImages barcodeImageGenerate = new GenerateBarcodeImages(barcodeGenerate.BarcodeNumbers);
			//barcodeImageGenerate.StartGenerating();
			//barcodeGenerate.ClearBarcodeNumbers();
		}
	}
}
