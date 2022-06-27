using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Turma
    {
        public string Identificacao { get; set; } //CA01 - PrimeiraClasse02
        public Professor Professor { get; set; }
        public List<Aluno> Alunos { get; set; }


        private Aluno[] AlunosArray { get; set; } //Tamanho Fixo = Pode ser usado quando especifico o número de lugares numa sala
        private ArrayList ObjetosArrayList { get; set; } //Cuidado!! Lista que aceita qualquer tipo de objeto

    }
}
