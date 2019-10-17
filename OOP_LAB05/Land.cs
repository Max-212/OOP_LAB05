using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB05
{
    public interface Land
    {
        void Message();
        string ToString();
    }

    public class Continent : Land
    {
        public string ContinentName { get; }
        public double ContinentSquare { get; }
        public virtual void Message()
        {
            Console.WriteLine("It is a Continent {0}", ContinentName);
        }
        public Continent(string name)
        {
            ContinentName = name;
            ContinentSquare = name.Length * 10;
        }

        public override string ToString()
        {
            return  "ContinentName: " + ContinentName + "\nContinentSquare: " + ContinentSquare + "\n" + base.ToString() + "\n";
        }
    }

    public sealed class State : Continent
    {
        public string StateName { get; }
        public double StateSquare { get; }
        public override void Message()
        {
            Console.WriteLine("It is a State {0}", StateName);
        }
        public State(string ContinentName , string StateName) : base(ContinentName)
        {
            this.StateName = StateName;
            StateSquare = StateName.Length * 2;
        }

        public override string ToString()
        {
            return "StateName: "+ StateName + "\nStateSquare: " + StateSquare + "\n" + base.ToString() + "\n";
        }

    }
}
