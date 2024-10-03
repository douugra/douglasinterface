using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace douglasinterface
{
    public class Aviao() : Ivoador, IMaquina
    {
        public void Abastecer()
        {
            Console.WriteLine("Ele Abastece");
        }

        public void Alerta()
        {
            Console.WriteLine("Ele Alerta");
        }

        public void Cair()
        {
            Console.WriteLine("Ele Cai");
        }

        public void Decolar()
        {
            Console.WriteLine("Ele Decola");
        }

        public void Desligar()
        {
            Console.WriteLine("Ele Desliga");
        }

        public void Ligar()
        {
            Console.WriteLine("Ele Liga");
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
