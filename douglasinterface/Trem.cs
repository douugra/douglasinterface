using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace douglasinterface
{
    public class Trem() : IMaquina
    {
        public void Abastecer()
        {
            Console.WriteLine("Ele Abastece");
        }

        public void Alerta()
        {
            Console.WriteLine("Ele Alerta");
        }

        public void Desligar()
        {
            Console.WriteLine("Ele Desliga");
        }

        public void Ligar()
        {
            Console.WriteLine("Ele Liga");
        }
    }
}
