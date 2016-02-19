using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureMapExample
{
    class FileReader : IFileReader
    {
        public void ReadFile()
        {
            Console.WriteLine("Reading File");
        }
    }
    
    public interface IFileReader {
        void ReadFile();
    }
}
