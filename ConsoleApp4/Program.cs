using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pictures = 52;
            int picturesInLine = 3;

            int lines = pictures / picturesInLine;
            int extaPictures = pictures % picturesInLine;
            Console.WriteLine(lines + " Lines and " + extaPictures + " extra pictures "); 

        }
    }
}
