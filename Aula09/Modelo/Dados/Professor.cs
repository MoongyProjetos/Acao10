namespace Modelo.Dados
{
    public class Professor : Pessoa
    {
        public string Especialidade { get; set; }

        public override bool ValidarDados()
        {
            return Idade >= 18 && string.IsNullOrWhiteSpace(Especialidade) != false;
        }

        public Professor()
        {

        }

        public Professor(string numeroIdentificacaoFiscal, string nome, string especialidade) : base(numeroIdentificacaoFiscal)
        {
            Nome = nome;
            Especialidade = especialidade;
            Sexo = Sexo.Feminino;
        }

        public Professor(string nome)
        {
            Nome = nome;
            DataNascimento = DateTime.Now;
        }

        public Professor(string nome, string especialidade)
        {
            Nome = nome;
            Especialidade = especialidade;
            DataNascimento = DateTime.Now;
        }

        public Professor(string nome, string especialidade, DateTime dataNascimento)
        {
            Nome = nome;
            Especialidade = especialidade;
            DataNascimento = dataNascimento;
        }
    }
}