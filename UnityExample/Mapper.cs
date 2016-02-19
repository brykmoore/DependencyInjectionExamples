using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityExample
{
    public class Mapper : IMapper
    {
        public void Map()
        {
            Console.WriteLine("Mapped file.");
        }
    }

    public interface IMapper
    {
        void Map();
    }
}
