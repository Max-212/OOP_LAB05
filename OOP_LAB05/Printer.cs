using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace OOP_LAB05
{
    public static class Printer
    {
        public static void IAmPrinting(Land land)
        {
            Console.WriteLine(land.ToString());
        }
    }
}
