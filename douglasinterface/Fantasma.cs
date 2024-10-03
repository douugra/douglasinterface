using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace douglasinterface
{
    public class Fantasma() : Ipairador
    {
        public void Cair()
        {
            Console.WriteLine("Ele Cai");
        }

        public void Decolar()
        {
            Console.WriteLine("Ele Decola");
        }

        public void Pairar()
        {
            Console.WriteLine("Ele Paira");
        }

        public void Planar()
        {
            Console.WriteLine("Ele Plana");
        }

        public void Pousar()
        {
            Console.WriteLine("Ele Pousa");
        }
    }
}
