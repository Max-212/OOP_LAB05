using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB05
{
    public abstract class Water
    {
        public string Name { get; }
        public double Square { get; }
        public abstract void Sound();
        public Water(string name, double square)
        {
            Name = name;
            Square = square;
        }
        public override string ToString()
        {
            return "Name: " + Name + "\nSquare: " + Square + "\n" + base.ToString() + "\n";
        }
    }

    public class Sea : Water
    {
        public override void Sound()
        {
            Console.WriteLine("Буль-буль-буль");
            
        }
        public Sea(string name) : base(name, name.Length * 10.0) { }
    }

}
