using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoorManDI
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileImporter = new FileImport();
            fileImporter = new FileImport(new CsvFileReader());
            fileImporter.ImportFile();

            Console.ReadLine();
        }
    }
}
