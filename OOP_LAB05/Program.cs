using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB05
{
    class Program
    {
        static void Main(string[] args)
        {
            Sea Black = new Sea("Black");
            Console.WriteLine(Black.ToString());

            Land[] array = new Land[2];

            State Russia = new State("Eurasia", "Russia");
            if (Russia is State) array[0] = Russia;
            State Egypt = new State("Africa", "Egypt");
            if (Egypt as State != null) array[1] = Egypt;
            foreach (var item in array)
                Printer.IAmPrinting(item);
                
        }
    }
}
