using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace douglasinterface
{
    public interface IMaquina
    {
        public void Ligar();
        public void Desligar();
        public void Abastecer();
        public void Alerta();

    }
}
