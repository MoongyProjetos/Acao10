﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoAssincrona
{
    public class Exemplos : IContrato
    {
        #region Metodos Síncronos Bloqueiam Fluxo de Execução
        public void ExemploMetodoSincrono()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Inicio: {DateTime.Now}");
            for (int i = 0; i < 10000; i++)
            {
                sb.AppendLine($"Exemplo conteudo {i}");
            }
            sb.AppendLine($"Final: {DateTime.Now}");

            File.AppendAllText(@"c:\temp\ExemploMetodoSincrono.txt", sb.ToString());

            Thread.Sleep(2000);
            Console.WriteLine("Eu sou o método síncrono");
        }

        public List<PessoaDTO> ExemploMetodoSincronoListagemPessoas()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Inicio: {DateTime.Now}");
            for (int i = 0; i < 10000; i++)
            {
                sb.AppendLine($"Exemplo conteudo {i}");
            }
            sb.AppendLine($"Final: {DateTime.Now}");

            File.AppendAllText(@"c:\temp\ExemploMetodoSincronoListagemPessoas.txt", sb.ToString());

            Thread.Sleep(2000);
            var listaPessoas = new List<PessoaDTO>();
            return listaPessoas;
        }

        #endregion 



        #region Metodos Assícronos execuçao em tasks / threads separadas
        public async Task ExemploMetodoAssincrono()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Inicio: {DateTime.Now}");
            for (int i = 0; i < 10000; i++)
            {
                sb.AppendLine($"Exemplo conteudo {i}");
            }
            sb.AppendLine($"Final: {DateTime.Now}");
            
            await File.AppendAllTextAsync(@"c:\temp\ExemploMetodoAssincrono.txt", sb.ToString());
            Thread.Sleep(2000);
            Console.WriteLine("Exemplo Metodo Assincrono");
        }

        public async Task<List<PessoaDTO>> ExemploMetodoAssincronoComLista()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Inicio: {DateTime.Now}");
            for (int i = 0; i < 10000; i++)
            {
                sb.AppendLine($"Exemplo conteudo {i}");
            }
            sb.AppendLine($"Final: {DateTime.Now}");
            
            await File.AppendAllTextAsync(@"c:\temp\ExemploMetodoAssincronoComLista.txt", sb.ToString());


            Thread.Sleep(2000);
            var listaPessoas = new List<PessoaDTO>();
            return listaPessoas;
        }

        #endregion Metodos Assícronos execuçao em tasks / threads separadas



    }
}
