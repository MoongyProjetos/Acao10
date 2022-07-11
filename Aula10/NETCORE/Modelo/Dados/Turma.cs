using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Dados
{
    public class Turma
    {
        public string Identificacao { get; set; } //CA01 - PrimeiraClasse02
        public Professor Professor { get; set; }
        public List<Aluno> Alunos { get; set; }


        public Aluno[] AlunosArray { get; set; } //Tamanho Fixo = Pode ser usado quando especifico o número de lugares numa sala
        public ArrayList ObjetosArrayList { get; set; } //Cuidado!! Lista que aceita qualquer tipo de objeto
        public List<Aluno> AlunosLista { get; set; }

    }
}
