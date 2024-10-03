using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace douglasinterface
{
    public class Passarinho() : ISerVivo, Ivoador
    {
        public void Cair()
        {
            Console.WriteLine("Ele Cai");
        }

        public void Comer()
        {
            Console.WriteLine("Ele Come");
        }

        public void Decolar()
        {
            Console.WriteLine("Ele Decola");
        }

        public void Dormir()
        {
            Console.WriteLine("Ele Dorme");
        }

        public void Morrer()
        {
            Console.WriteLine("Ele morre");
        }

        public void Planar()
        {
            Console.WriteLine("Ele Plana");
        }

        public void Pousar()
        {
            Console.WriteLine("Ele Pousa");
        }

        public void Respirar()
        {
            Console.WriteLine("Ele Respira");
        }
    }
}
