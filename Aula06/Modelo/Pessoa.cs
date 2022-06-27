using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Pessoa: IComparable<Pessoa>
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Sexo Sexo { get; set; }        
        public string NumeroIdentificacaoFiscal { get; set; }
        public List<Morada> Moradas { get; set; }

        public int Idade  => DateTime.Now.Year - DataNascimento.Year;
        public DateTime DataCriacao { get; init; }
        public string Exemplo{ get; init; }


        protected string CampoProtegido { get; set; }

        public int CompareTo(Pessoa? other)
        {
            return this.DataNascimento.Year - other.DataNascimento.Year;
        }
    }
}


