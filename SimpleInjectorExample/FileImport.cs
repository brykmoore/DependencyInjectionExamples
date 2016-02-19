using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjectorExample
{
    public class FileImport : IFileImport
    {
        public IFileReader _fileReader;
        public IMapper _mapper;
        public IFileProcessor _fileProcessor;

        public FileImport(IFileReader fileReader, IMapper mapper, IFileProcessor fileProcesor)
        {
            _fileReader = fileReader;
            _mapper = mapper;
            _fileProcessor = fileProcesor;
        }

        public void ImportFile()
        {
            _fileReader.ReadFile();
            _mapper.Map();
            _fileProcessor.ProcessFile();
        }

    }



    public interface IFileImport
    {
        void ImportFile();
    }
}
