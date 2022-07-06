using Modelo.Impressao;
using Modelo.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Dados
{
    //classe aluno herda de pessoa
    //classe aluno implementa métodos IRepositorio

    public class Aluno : Pessoa, IRepositorio<Aluno, int>, IImpressora
    {
        public int CodigoAluno { get; set; }

        public bool Aprovado => CalcularResultado();


        public bool AprovadoNovo => Nota >= 10;

        public bool AprovadoAntigo
        {
            get
            {
                return Nota >= 0;
            }
        }


        public string PropriedadeIniciadaNoConstrutor { get; init; }

        public Aluno()
        {
            CampoProtegido = "teste";
            PropriedadeIniciadaNoConstrutor = "exemplo";
        }

        public Aluno(string nome)
        {
            Nome = nome;
            CodigoAluno = new Random().Next();
        }

        public Aluno(int codigoAluno, string nome)
        {
            Nome = nome;
            CodigoAluno = codigoAluno;
        }

        private int Nota { get; set; }
        private bool CalcularResultado()
        {
            return Nota >= 10;
        }


        public static void WriteLine(string s)
        {
            ///
        }

        public void Imprimir()
        {
            throw new NotImplementedException();
        }

        public void Adicionar(Aluno item)
        {
            throw new NotImplementedException();
        }

        public Aluno Recuperar(int id)
        {
            throw new NotImplementedException();
        }

        public Aluno Atualizar(int item)
        {
            throw new NotImplementedException();
        }

        public List<Aluno> Recuperar(int id, int qtd)
        {
            var lista = new List<Aluno>();
            return lista.OrderBy(x => x.DataNascimento).ToList();
        }

        public override bool ValidarDados()
        {
            return Idade >= 0 && String.IsNullOrWhiteSpace(Nome) == false;
        }

        public override string ExibirDadosVirtual()
        {
            return "Classe Aluno";
        }

        public override string ToString()
        {
            return "Nome " + Nome;
        }
    }
}
