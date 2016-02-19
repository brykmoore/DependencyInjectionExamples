using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace UnityExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            container.RegisterType<IFileReader, CsvFileReader>();
            container.RegisterType<IMapper, Mapper>();
            container.RegisterType<IFileProcessor, FileProcessor>();

            var fileImporter = container.Resolve<FileImport>();
            fileImporter.ImportFile();
        }
    }
}
