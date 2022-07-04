using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Dados
{
    public class Agrupamento
    {
        public List<Escola> Escolas { get; set; }

        public Dictionary<string, string> Distrito { get; set; }
    }
}