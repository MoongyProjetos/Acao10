using Entidades;
using System.Collections;
using System.Diagnostics;
using System.Text;

namespace EscolaCRM
{
    public class ExcecaoPersonalizada : Exception
    {
        public ExcecaoPersonalizada(string mensagem)
        {
            File.WriteAllText(@"d:\temp\excecaoxpto.txt", this.ToString());
        }
    }

    public static class Program
    {
        public static void Main(string[] args)
        {
            var estudante = new Estudante();
            estudante.Nome = "Joaozinho";
            Console.WriteLine(estudante.ToString());

            var professor = new Professor();
            professor.Nome = "RAimundo";
            professor.Especialidade = "Matematica";
            professor.DataNascimento = new DateTime(1990, 1, 1);
            Console.WriteLine(professor.ToString());


            var minhaApp = "AplicacaoExemplo";
            if (!EventLog.SourceExists(minhaApp))
            {
                EventLog.CreateEventSource(minhaApp, "MyNewLog");                
            }

            
            EventLog myLog = new EventLog();
            myLog.Source = minhaApp;            
            myLog.WriteEntry("Writing to event log.");
            myLog.WriteEntry("Exemplo Exceção", EventLogEntryType.Error);



            LogHelper.EscreverLog("Oi aconteceu um problema");


            ArrayList samplesList = new ArrayList();
            var perfmon = new MonitorPerformance();
            perfmon.CreateCounters();


            MonitorPerformance.CollectSamples(samplesList);





            //var divisor = 0;
            //var dividendo = 1;

            ////if(divisor == 0){
            ////    throw new ExcecaoPersonalizada("Exemplo de erro genérico ....");
            ////}






            //try
            //{
            //     var resultado = dividendo / divisor;
            //    File.ReadAllLines(@"d:\temp\log_divisaoporzero_inexistente.txt");
            //}
            //catch (DivideByZeroException ex) when (ex.Message.Contains("zero"))
            //{
            //    var sb = new StringBuilder();
            //    sb.Append(DateTime.Now);
            //    sb.Append("[ERRO]");
            //    sb.Append(ex.Message);
            //    sb.Append(ex.StackTrace);
            //    sb.Append(" Dividendo: " + dividendo);
            //    sb.Append(" Divisor: " + divisor);

            //    File.WriteAllText(@"d:\temp\log_divisaoporzero_novo.txt", sb.ToString());
            //}
            //catch (Exception ex)
            //{
            //    File.WriteAllText(@"d:\temp\log.txt", ex.StackTrace);
            //}
            //finally
            //{
            //    File.WriteAllText(@"d:\temp\log_execucao.txt", "Foi executado no dia tal ...");
            //}


            //Console.WriteLine("Cheguei até aqui");
        }







        public static string ExemploMahPraticaVariosPontosDeSaida(int posicao, out string mensagem)
        {
            var resultado = "";
            switch (posicao)
            {
                case 0: resultado = "VAlor 0";
                    break;
                case 1: resultado = "VAlor 1";
                    break;
                case 10: resultado = "VAlor 10";
                    break;
                default: resultado = "Nao sei";
                    break;
            }

            mensagem = "Loucura";
            return resultado;
        }


        public static void ExemploParametroOpcional(
            string param1, 
            string param2 = " mundo ", 
            string param3 = null)
        {
            Console.WriteLine(param1 + " " + param2);
        }

        public static void Exemplo(ref double param)
        {
            //GuardCondition
            if (param == 0)
            {
                return;
            }

            param += 10; 
            Console.WriteLine("Valor do Parametro Passado: "+ param);
        }

        public static void Exemplo02(double param)
        {
            if (param != 0)
            {
                Console.WriteLine("Exemplo executado");
            }
            else
            {
                ///
            }
        }





        public static double Somar(double valor01 = 10, double valor02 = 0, double valo03 = 3)
        {
            double resultado = 0;
            resultado = valor01 + valor02;


            return resultado;
        }


        public static void ExemploAula01()
        {
            #region MyRegion

            Estudante joaozinho = new Estudante();
            joaozinho.Nome = "Joaozinho";
            joaozinho.NumeroRegistro = 1;
            joaozinho.DataNascimento = new DateTime(2019, 01, 01);
            joaozinho.EnderecoEletronico = "joao@gmail.com";

            Console.WriteLine(" Nome: " + joaozinho.Nome +
                              " idade: " + joaozinho.ObterIdade() +
                              " dataNascimento:" + joaozinho.DataNascimento +
                              " emailValido: " + joaozinho.ValidarEnderecoEletronico());

            var valor = "1234";
            var valor2 = "4321";

            Console.WriteLine(Convert.ToInt32(valor) + Convert.ToInt32(valor2));




            Estudante mariazinha = new Estudante { Nome = "Mariazinha", DataNascimento = new DateTime(2018, 12, 12), NumeroRegistro = 2 };


            var idadeJoaozinho = joaozinho.ObterIdade();
            var idadeMariazinha = mariazinha.ObterIdade();

            var somatorioIdades = idadeJoaozinho + idadeMariazinha;
            Console.WriteLine(somatorioIdades);

            ///Sobrecarga /Overload
            ///   ++operator;

            Console.WriteLine(joaozinho.Nome + mariazinha.Nome);






            var exemplo = "nome do exemplo";
            var exemplo02 = true;
            var exemplo03 = 140;
            var exemplo04 = 100000000000000000000000000000000000001f;

            var pedrinho = new Estudante { Nome = "Pedrinho" };
            pedrinho.Nome = "Pedrinho de novo";


            StringBuilder sb = new StringBuilder();
            sb.Append("Inicio");
            sb.Append(" da ");
            sb.Append(" minha ");
            sb.Append(" frase ");

            var minhaVar = sb.ToString();



            var turmaExemplo = new Turma();
            turmaExemplo.Identificacao = "Turma Exemplo";
            turmaExemplo.Pessoas = new Pessoa[4];
            turmaExemplo.Pessoas[0] = joaozinho;
            turmaExemplo.Pessoas[1] = mariazinha;
            turmaExemplo.Pessoas[2] = pedrinho;

            var raimundo = new Professor();
            raimundo.Nome = "Raimundo";
            raimundo.Especialidade = "Matemática";

            turmaExemplo.Pessoas[3] = raimundo;


            for (int i = 0; i < turmaExemplo.Pessoas.Length; i++)
            {
                if (turmaExemplo.Pessoas[i] is Professor)
                {
                    Console.WriteLine((turmaExemplo.Pessoas[i] as Professor).Especialidade);
                    var esp = ((Professor)turmaExemplo.Pessoas[i]).Especialidade;
                }
            }



            #endregion


            //for
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < turmaExemplo.Pessoas.Length; i++)
            {
                Console.WriteLine(turmaExemplo.Pessoas[i].Nome);
            }

            //while
            int quantidadePessoas = turmaExemplo.Pessoas.Length;
            int contador = 0;
            while (contador < quantidadePessoas)
            {
                Console.WriteLine(turmaExemplo.Pessoas[contador].Nome);
                contador++;
            }

            //contador aqui = 3
            //do while
            do
            {
                //Por acaso imprime pedrinho por causa do -1
                Console.WriteLine(turmaExemplo.Pessoas[contador - 1].Nome);
                contador++;
            } while (contador < quantidadePessoas);

            //foreach
            foreach (var pessoa in turmaExemplo.Pessoas)
            {
                Console.WriteLine(pessoa.Nome);
            }

            //Switch
            var numero = 1;

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Numero = 1");
                    break;
                case 2:
                    Console.WriteLine("Numero = 2");
                    break;
                case 3:
                    Console.WriteLine("Numero = 3");
                    break;
                default:
                    Console.WriteLine("Certeza que é numero?");
                    break;
            }


            Console.ReadLine();
        }


        public static void ExemploAula02()
        {
            //double minhaVar = 1;
            //Exemplo(ref minhaVar);

            //Console.WriteLine("Minha Var: " + minhaVar);
            ////Console.ReadLine();


            //Console.WriteLine("oi " + " mundo"); //oi mundo
            //Console.WriteLine(1 + 1); //2

            var joaozinho = new Estudante();
            joaozinho.Nome = "Joaozinho";


            var raimundo = new Professor();
            raimundo.Nome = "Raimundo";
            raimundo.Especialidade = "Matematica";


            var turma = new Turma();
            turma.AddPessoas(joaozinho);
            turma.AddPessoas(raimundo);



            ExemploParametroOpcional("oi", "amigo", param3: "xcfsfds");
            var exemplo = "exemplo";
            ExemploMahPraticaVariosPontosDeSaida(1, out exemplo);
            Console.WriteLine(exemplo);
        }
    }
}
