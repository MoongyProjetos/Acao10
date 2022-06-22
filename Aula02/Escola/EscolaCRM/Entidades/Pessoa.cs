using System.Text.RegularExpressions;

namespace Entidades
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; } 
        public int NumeroRegistro { get; set; }
        public string EnderecoEletronico { get; set; }
        public string Sexo { get; set; }

        public string ObterCumprimento()
        {
            if(Sexo == "M")
            {
                return "Obrigado";
            }
            else
            {
                if(Sexo == "F")
                {
                    return "Obrigada";
                }
                else
                {
                    return "Ops";
                }                
            }
        }

        public int ObterIdade()
        {
            var idade = DateTime.Now.Year - DataNascimento.Year; 
            return idade;
        }

        const int IdadeMaxima = 99;
        const int IdadeMinima = 3;
        public bool ValidarIdade()
        {
            var resultado = true;

            var idade = ObterIdade();
            if(idade < IdadeMinima)
            {
                resultado = false;
            }

            if(idade > IdadeMaxima)
            {
                resultado = false;
            }

            return resultado;
        }

        public bool ValidarEnderecoEletronico()
        {
            //tem que ter @
            //só pode ter 1 @
            //.com . edu
            var evalido = false;
            var expressaoValidacao = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            //Big Farms Needs Red Tractors
            // \b \f \n \r \t

            evalido = Regex.IsMatch(EnderecoEletronico, expressaoValidacao);

            return evalido;
        }

        public override string ToString()
        {
            return "Nome: " + Nome;
        }
    }
}
