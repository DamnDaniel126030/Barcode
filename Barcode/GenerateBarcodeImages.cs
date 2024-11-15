using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;

namespace Barcode
{
	internal class GenerateBarcodeImages
	{
		public List<string> Barcodes { get; set; }

		public GenerateBarcodeImages(List<string> barcodes)
		{
			Barcodes = barcodes;
		}

		public void GenerateImages()
		{
			
		}
	}
}
