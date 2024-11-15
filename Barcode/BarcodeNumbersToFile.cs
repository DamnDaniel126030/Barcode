using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Barcode
{
	internal class BarcodeNumbersToFile
	{
		public int NumberOfBarcodes { get; set; }
		public List<string> BarcodeNumbers { get; set; }
		public string FileName { get; set; }
		public Random rnd = new Random();

		public BarcodeNumbersToFile(int numberOfBarcodes, string fileName)
		{
			NumberOfBarcodes = numberOfBarcodes;
			BarcodeNumbers = new List<string>();
			FileName = fileName;
		}

		private void GenerateNumbers()
		{
			int random = rnd.Next(0, 10);
			string barcode = "";

            for (int i = 0; i < NumberOfBarcodes; i++)
            {
				while (barcode.Length != 13)
				{
					barcode += string.Concat(random);
					random = rnd.Next(0, 10);
				}
				BarcodeNumbers.Add(barcode);
				barcode = "";
			}
        }

		public void ClearBarcodeNumbers()
		{
			BarcodeNumbers.Clear();
		}
		
		private void CreateTxt()
		{
			try
			{
				if (File.Exists(FileName))
				{
					File.Delete(FileName);
				}
				else
				{
					File.Create(FileName);
				}
				Console.WriteLine("File created");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		private void WriteIntoTxt()
		{
			StreamWriter sw = File.CreateText(FileName);
			foreach (string barcode in BarcodeNumbers)
			{
				sw.WriteLine(barcode);
			}
			sw.Close();
		}

		public void StartGenerating()
		{
			GenerateNumbers();
			CreateTxt();
			WriteIntoTxt();
		}
	}
}
