using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutDependencyInjection
{
    public class FileImport
    {
        private CsvFileReader _fileReader;

        public FileImport()
        {
            _fileReader = new CsvFileReader();
        }

        public void ImportFile()
        {
            _fileReader.ReadFile();
        }
    }
}
