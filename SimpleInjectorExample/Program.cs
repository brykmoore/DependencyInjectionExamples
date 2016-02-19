using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;

namespace SimpleInjectorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container();
            container.Register<IFileReader, CsvFileReader>();
            container.Register<IMapper, Mapper>();
            container.Register<IFileProcessor, FileProcessor>();

            var fileImporter = container.GetInstance<FileImport>();
            fileImporter.ImportFile();
            Console.ReadLine();
        }
    }
}
