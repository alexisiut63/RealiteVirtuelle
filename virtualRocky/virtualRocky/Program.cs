using Rokinect.metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualRocky
{
    class Program
    {
        static void Main(string[] args)
        {
            Player x = new Player(100, 175);
            Gesture a = new LeftKick();
            x.takeBlow(a);


            Console.ReadKey(true);
            Console.Clear();
        }
    }
}
