using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Funcionario : Pessoa
    {
        public DiasSemana DiaDeFolga { get; set; }

        public override string ToString()
        {
            return "Oi sou o funcionario" + Nome;
        }
    }
}
