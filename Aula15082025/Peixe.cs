using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Peixe : Animal
    {
        public override void Falar() => Console.WriteLine("Peixe falar - GLUB GLUB");

        public override void Respirar() => Console.WriteLine("Peixe respirar - ÁGUA");
    }
}
