using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Sexo Sexo { get; set; }        
        public List<Morada> Moradas { get; set; }

        public int Idade  => DateTime.Now.Year - DataNascimento.Year;
        public DateTime DataCriacao { get; init; }

        public Pessoa()
        {

        }

        public Pessoa(string nome)
        {
            Nome = nome;
            //this.Nome = nome;
        }

    }
}