using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula18082025.Aeroporto
{
    internal class Gryphon : FliyngTransport
    {
        public Gryphon(Airport a) => Origin = a;

        public override void EuSou()
        {
            Console.WriteLine("Eu sou um Gryphon");
        }

        
    }
}
