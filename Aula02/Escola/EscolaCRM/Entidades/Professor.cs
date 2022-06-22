using System.Text;

namespace Entidades
{
    public class Professor : Pessoa
    {
        public string Especialidade { get; set; }

        //Sobrescrita do método base
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Nome: " + Nome);
            sb.AppendLine("Especialidade: " + Especialidade);
            sb.AppendLine("Idade: " + ObterIdade());

            return sb.ToString();
        }
    }
}
