using Modelo.Impressao;
using Modelo.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Aluno : Pessoa, IRepositorio, IImpressora
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

        public void Adicionar()
        {
            throw new NotImplementedException();
        }

        public object Recuperar()
        {
            throw new NotImplementedException();
        }

        public string Atualizar()
        {
            throw new NotImplementedException();
        }

        public void Imprimir()
        {
            throw new NotImplementedException();
        }
    }
}
