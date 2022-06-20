namespace Entidades
{
    public class Turma
    {
        public string Identificacao { get; set; }
        public Pessoa[] Pessoas { get; set; }

        public void AddPessoas(Estudante aluno)
        {
            Console.WriteLine("Estudante Adicionado : " + aluno.Nome);
        }

        public void AddPessoas(Professor professor)
        {
            Console.WriteLine("Professor Adicionado : " + professor.Nome + " professor de: " + professor.Especialidade);
        }

        //Sobrecarga
        public void AddPessoas(string nome)
        {

        }

        //Sobrecarga
        public void AddPessoas(int identificador)
        {

        }


        //Sobrecarga
        public void AddPessoas(double identificador)
        {

        }

        //Override
        public void AddPessoas(double identificador, string nome)
        {

        }


        public string AddPessoas(double identificador, string nome, DateTime dataNascimento)
        {
            return "";
        }
    }
}
