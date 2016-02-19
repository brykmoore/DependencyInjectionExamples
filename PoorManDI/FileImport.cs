using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoorManDI
{
    public class FileImport 
    {
        private IFileReader _fileReader;

        public FileImport() 
            : this(new CsvFileReader()){
        }

        public FileImport(IFileReader fileReader)
        {
            _fileReader = fileReader;
        }

        public void ImportFile()
        {
            _fileReader.ReadFile();
        }
    }
}
