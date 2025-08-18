using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula18082025.Aeroporto
{
    internal class Airport
    {

        public List<FliyngTransport> Transportes;

        public Airport()
        { 
            Transportes = [];
        }

        public void Accept(FliyngTransport FliyngTransport)
        {
            this.Transportes.Add(FliyngTransport);
        }

        public void Bye(FliyngTransport FliyngTransport)
        {
            this.Transportes.Remove(FliyngTransport);
        }
    }
}
