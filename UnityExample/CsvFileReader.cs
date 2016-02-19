using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityExample
{
    class CsvFileReader : IFileReader
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
