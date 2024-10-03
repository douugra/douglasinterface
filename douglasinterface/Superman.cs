using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace douglasinterface
{
    public class Superman() : ISerVivo, Ivoador, Ipairador
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
            Console.WriteLine("Ele decola");
        }

        public void Dormir()
        {
            Console.WriteLine("Ele dorme");
        }

        public void Morrer()
        {
            Console.WriteLine("Ele morre");
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

        public void Respirar()
        {
            Console.WriteLine("Ele Respira");
        }
    }
}
