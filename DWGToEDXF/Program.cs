using Aspose.CAD;
using Aspose.CAD.FileFormats.Cad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWGToEDXF
{
    class Program
    {
        public static void LoadLicense()
        {

            try
            {
                String licPath = @"C:\Aspose Data\Aspose.Total.Product.Family.lic";

                Aspose.CAD.License lic = new Aspose.CAD.License();
                lic.SetLicense(licPath);
            }
            catch(Exception e)
            {
                String s = e.StackTrace;
            }
            
            
        }
        static void Main(string[] args)
        {
            LoadLicense();

            try
            {
                string inputFile = "Line.dwg";
                string outFile = "Line.dxf";
                using (var cadImage = (CadImage)Image.Load(inputFile))
                {
                    cadImage.Save(outFile);
                }
            }
            catch(Exception ex)
            {

                String Message = ex.StackTrace;
            }


        }
    }
}
