using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutDependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileImporter = new FileImport();
            fileImporter.ImportFile();

            Console.ReadLine();
        }
    }
}
