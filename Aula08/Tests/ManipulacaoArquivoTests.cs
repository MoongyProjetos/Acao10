using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace Tests
{
    [TestClass]
    public class ManipulacaoArquivoTests
    {
        [TestMethod]
        public void DeveEscreverInformacaoEmUmTxtTest()
        {
            //Arrange
            var caminho = @"c:\temp\meuarquivo.txt";
            var conteudo = DateTime.Now.ToString();

            //Act
            File.WriteAllText(caminho, conteudo);

            //Assert
            Assert.IsTrue(File.Exists(caminho));
        }


        [TestMethod]
        public void DeveAdicionarInformacaoEmUmTxtTest()
        {
            //Arrange
            var caminho = @"c:\temp\meuarquivo.txt";
            var conteudo = DateTime.Now.ToString();

            //Act
            File.AppendAllText(caminho, conteudo);

            //Assert
            Assert.IsTrue(File.Exists(caminho));
        }

        [TestMethod]
        public void DeveriaRecuperarInformacaoEmUmTxtTest()
        {
            //Arrange
            var caminho = @"c:\temp\meuarquivo.txt";
            var exemplo = "Oi mundo";

            //Act
            File.WriteAllText(caminho, exemplo);
            var conteudo = File.ReadAllText(caminho);

            //Assert
            Assert.IsNotNull(conteudo);
        }

        [TestMethod]
        public void DeveriaRecuperarInformacaoEmUmTxtEmListaTest()
        {
            //Arrange
            var caminho = @"c:\temp\meuarquivo.txt";
            var exemplo = @"Oi mundo 
                            Teste de multiplas linhas
                            exempl 01
                            Multiplas linhas";

            //Act
            File.WriteAllText(caminho, exemplo);
            var conteudo = File.ReadAllLines(caminho);


            //Assert
            Assert.IsNotNull(conteudo);
            foreach (var item in conteudo)
            {
                Assert.IsTrue(!string.IsNullOrEmpty(item));
            }
        }

        [TestMethod]
        public void DeveriaRecuperarInformacaoEmUmTxtDeDadosBancariosListaTest()
        {
            //Arrange
            var caminho = @"C:\temp\DadosBancarios.csv";
            var sb = new StringBuilder();
            sb.AppendLine("Nome;Idade;Saldo Bancario");
            sb.AppendLine("Joao;21;1000.18");
            sb.AppendLine("Maria;54;100000$12");
            sb.AppendLine("Pedro;35;€25000.19");
            sb.AppendLine("...;...;...");

            //Act
            File.WriteAllText(caminho, sb.ToString());
            var conteudo = File.ReadAllLines(caminho);
            var dadosBancariosListagem = new List<DadosBancarios>();

            for (int i = 1; i <= conteudo.Length - 2; i++)
            {
                var dados = conteudo[i].Split(';');

                var dadosBancarios = new DadosBancarios();
                dadosBancarios.Nome = dados[0];
                dadosBancarios.Idade = Convert.ToInt32(dados[1]);

                var salarioTemporario = dados[2];
                if (salarioTemporario.Contains("€"))
                {
                    var sal = salarioTemporario.Replace("€", "");
                    dadosBancarios.SaldoBancario = Convert.ToDecimal(sal, CultureInfo.InvariantCulture);
                    dadosBancarios.Moeda = "Euro";
                }
                else
                {
                    if (salarioTemporario.Contains("$"))
                    {
                        var sal = salarioTemporario.Replace("$", ".");
                        dadosBancarios.SaldoBancario = Convert.ToDecimal(sal, CultureInfo.InvariantCulture);
                        dadosBancarios.Moeda = "Escudos";
                    }
                    else
                    {
                        dadosBancarios.SaldoBancario = Convert.ToDecimal(salarioTemporario, CultureInfo.InvariantCulture);
                        dadosBancarios.Moeda = "Dólar";
                    }
                }


                dadosBancariosListagem.Add(dadosBancarios);
            }

            //Assert
            Assert.IsNotNull(conteudo);
            Assert.AreEqual(3, dadosBancariosListagem.Count);
        }

        [TestMethod]
        public void DeveApagarUmArquivoSeEleExistirTest()
        {
            //Arrange
            var caminho = @"c:\temp\meuarquivo.txt";
            var conteudo = DateTime.Now.ToString();

            //Act
            File.WriteAllText(caminho, conteudo);
            var existia = File.Exists(caminho);
            var dataCriacao = new DateTime();

            if (existia)
            {
                dataCriacao = File.GetCreationTime(caminho);
                File.Delete(caminho);
            }
            var existe = File.Exists(caminho);

            //Assert
            Assert.IsNotNull(dataCriacao);
            Assert.IsTrue(existia);
            Assert.IsFalse(existe);
        }

        [TestMethod]
        public void DeveRecuperarDadosDeUmArquivoSeEleExistirTest()
        {
            //Arrange
            var caminho = @"c:\temp\meuarquivo.txt";
            var conteudo = DateTime.Now.ToString();

            //Act
            File.WriteAllText(caminho, conteudo);
            var existia = File.Exists(caminho);
            var dataCriacao = new DateTime();

            if (existia)
            {
                dataCriacao = File.GetCreationTime(caminho);

                var informacoesArquivo = new FileInfo(caminho);
                File.Delete(caminho);
            }
            var existe = File.Exists(caminho);

            //Assert
            Assert.IsNotNull(dataCriacao);
            Assert.IsTrue(existia);
            Assert.IsFalse(existe);
        }

        [TestMethod]
        public void DeveriaRecuperarInformacaoEmUmTxtDeDadosBancariosListaEGravarEmJSONTest()
        {
            //Arrange
            var caminho = @"C:\temp\DadosBancarios.csv";
            var sb = new StringBuilder();
            sb.AppendLine("Nome;Idade;Saldo Bancario");
            sb.AppendLine("Joao;21;1000.18");
            sb.AppendLine("Maria;54;100000$12");
            sb.AppendLine("Pedro;35;€25000.19");
            sb.AppendLine("...;...;...");

            //Act
            File.WriteAllText(caminho, sb.ToString());
            var conteudo = File.ReadAllLines(caminho);
            var dadosBancariosListagem = new List<DadosBancarios>();

            for (int i = 1; i <= conteudo.Length - 2; i++)
            {
                var dados = conteudo[i].Split(';');

                var dadosBancarios = new DadosBancarios();
                dadosBancarios.Nome = dados[0];
                dadosBancarios.Idade = Convert.ToInt32(dados[1]);

                var salarioTemporario = dados[2];
                if (salarioTemporario.Contains("€"))
                {
                    var sal = salarioTemporario.Replace("€", "");
                    dadosBancarios.SaldoBancario = Convert.ToDecimal(sal, CultureInfo.InvariantCulture);
                    dadosBancarios.Moeda = "Euro";
                }
                else
                {
                    if (salarioTemporario.Contains("$"))
                    {
                        var sal = salarioTemporario.Replace("$", ".");
                        dadosBancarios.SaldoBancario = Convert.ToDecimal(sal, CultureInfo.InvariantCulture);
                        dadosBancarios.Moeda = "Escudos";
                    }
                    else
                    {
                        dadosBancarios.SaldoBancario = Convert.ToDecimal(salarioTemporario, CultureInfo.InvariantCulture);
                        dadosBancarios.Moeda = "Dólar";
                    }
                }

                dadosBancariosListagem.Add(dadosBancarios);
            }
            string listagemJson = JsonConvert.SerializeObject(dadosBancariosListagem);
            File.WriteAllText(@"c:\temp\listagem.json", listagemJson);


            //Assert
            Assert.IsNotNull(conteudo);
            Assert.AreEqual(3, dadosBancariosListagem.Count);
        }

        [TestMethod]
        public void DeveriaCarregarUmJsonEmUmaListaTest()
        {
            //arrange
            var caminho = @"c:\temp\listagem.json";

            //act
            var conteudo = File.ReadAllText(caminho);
            var lista = JsonConvert.DeserializeObject<List<DadosBancarios>>(conteudo);

            //assert
            Assert.AreEqual(3, lista.Count);
        }

        [TestMethod]
        public void DeveriaVerificarSeUmDiretorioExisteTeste()
        {
            //arrange
            var caminho = @"c:\temp2\";
            //act            
            if (!Directory.Exists(caminho))
            {
                Directory.CreateDirectory(caminho);
            }

            if (Directory.Exists(caminho))
            {
                Directory.Delete(caminho);
            }
        }

    }
}
