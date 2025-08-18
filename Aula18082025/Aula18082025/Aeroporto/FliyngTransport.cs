using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula18082025.Aeroporto
{
    internal abstract class FliyngTransport
    {
        public Airport? Origin {  get; set; }
        public Airport? Desting { get; set; }
        public int? Passegers { get; set; }


        public virtual void Fly(Airport desting, int passegers) 
        {
            Desting = desting;
            Passegers = passegers;

            Origin.Bye(this);
            Desting.Accept(this);
        }

        public abstract void EuSou();
    }
}
