using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new NovaEscolaDBEntities();
            //var turmaNova = new Turma();
            //turmaNova.Nome = "Cachorrinhos";
            //db.Turma.Add(turmaNova);


            //var carlos = new Aluno();
            //carlos.Nome = "Carlos";
            //carlos.DataNascimento = DateTime.Now;
            //carlos.TurmaId = 1;
            //db.Aluno.Add(carlos);

            //var maria = new Aluno();
            //maria.Nome = "Maria Dos Cachorrinhos";
            //maria.DataNascimento = DateTime.Now;
            //maria.TurmaId = 2;
            //db.Aluno.Add(maria);

            //var marta = new Aluno();
            //marta.Nome = "Marta Dos Cachorrinhos";
            //marta.DataNascimento = DateTime.Now;
            //marta.Turma =  new Turma { Nome = "Turma Nova Criada do Nada"};
            //db.Aluno.Add(marta);


            //LINQ - Linguagem integrada de queries
            var listaDeNumeros = new List<int> { 1, 2, 3, 4, 5 };
            var listaPares = listaDeNumeros.Where(x => x % 2 == 0).ToList();



            var listaResultado = new List<int>();
            foreach (var item in listaDeNumeros)
            {
                if (item % 2 == 0)
                {
                    listaResultado.Add(item);
                }
            }




            var alunosSelecionados = db.Aluno.Where(aluno => aluno.Nome.StartsWith("Marta")).ToList();

            foreach (var item in alunosSelecionados)
            {
                Console.WriteLine(item.Turma.Nome);
                item.Nome = "Nova Pessoa ";
            }


            var idea = db.Aluno.SqlQuery("Select * from aluno")
                .Take(5)
                .OrderBy(x => x.Nome)
                .Skip(1)
                .ToList()
                .OrderByDescending(x => x.Nome);




            var alunosDaTurmaDosUrsinhos = db.Aluno
                .Where(aluno =>
                aluno.Turma.Nome.StartsWith("U")
                && aluno.DataNascimento <= new DateTime(2019, 01, 01)
            ).ToList();



            //db.SaveChanges();


            //Formato antigo

            var connectionString = (ConfigurationManager.ConnectionStrings["ConexaoLimpa"]).ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("Select * from aluno where nome = @meuparametro")
                {
                    Connection = connection
                };


                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@meuparametro",
                    SqlDbType = SqlDbType.NVarChar,
                    Direction = ParameterDirection.Input,
                    Value = "Carlos"
                };
                command.Parameters.Add(parameter);

                // Open the connection and execute the reader.
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("{0}: {1:C}", reader[0], reader[1]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No rows found.");
                    }
                    reader.Close();
                }
            }

        }
    }
}
