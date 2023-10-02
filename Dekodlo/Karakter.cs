using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekodlo
{
    class Karakter
    {
        public char Betu { get; set; }
        public bool[,] Matrix { get; set; }

        public Karakter(char betu, bool[,] matrix)
        {
            Betu = betu;
            Matrix = matrix;
        }
    }

}
