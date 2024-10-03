using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace douglasinterface
{
    public class dinossauro() : ISerVivo
    {
        public void Comer()
        {
            Console.WriteLine("Ele come");
        }

        public void Dormir()
        {
            Console.WriteLine("Ele Dorme");
        }

        public void Morrer()
        {
            Console.WriteLine("Ele Morre");
        }

        public void Respirar()
        {
            Console.WriteLine("Ele Respira");
        }
    }
}
