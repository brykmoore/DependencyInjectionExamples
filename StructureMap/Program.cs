using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;
using StructureMap.Configuration;
using StructureMap.Graph;

namespace StructureMapExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container(x =>
            {
                x.For<IFileReader>().Use<FileReader>();
                x.For<IMapper>().Use<Mapper>();
                x.For<IFileProcessor>().Use<FileProcessor>();
            });

            var fileImporter = container.GetInstance<FileImport>();
            fileImporter.ImportFile();
        }
    }
}
