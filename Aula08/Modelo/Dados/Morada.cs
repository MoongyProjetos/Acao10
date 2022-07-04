using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Dados
{
    public struct Morada
    {
        public string Rua { get; set; }
        public string NumeroPorta { get; set; }
        public CodigoPostal CodigoPostal { get; set; }
        public TipoMorada TipoMorada { get; set; }
    }
}
