using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Turma
    {
        public string Identificacao{ get; set; } //CA01 - PrimeiraClasse02
        public Professor Professor { get; set; }
        
        public Estudante[] EstudantesArray { get; set; }
    }
}
