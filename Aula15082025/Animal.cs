using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal abstract class Animal : SerVivo
    {
        public void Mover() => Console.WriteLine("Animal mover");
        public virtual void Respirar() => Console.WriteLine("Animal respirar - AR");
        public abstract void Falar();
    }
}
