using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureMapExample
{
    public class FileProcessor : IFileProcessor
    {
        public void ProcessFile()
        {
            Console.WriteLine("File Processed");
        }
    }

    public interface IFileProcessor
    {
        void ProcessFile();
    }
}
