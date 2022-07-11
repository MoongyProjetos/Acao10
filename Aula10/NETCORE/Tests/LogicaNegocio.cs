using LogicaNegocio;

namespace Tests
{
    [TestClass]
    public class LogicaNegocio
    {
        [TestMethod]
        public void NaoDeveValidarNifComMaisDe9Digitos()
        {
            //Arrange 
            var nif = "1234567890";

            //Act
            var estaValido = Documento.ValidarNif(nif);

            //Assert 
            Assert.IsFalse(estaValido);
        }


        [TestMethod]
        public void NaoDeveValidarNifComMenosDe9Digitos()
        {
            //Arrange 
            var nif = "12345678";

            //Act
            var estaValido = Documento.ValidarNif(nif);

            //Assert 
            Assert.IsFalse(estaValido);
        }

        [TestMethod]
        public void NaoDeveValidarNifComLetra()
        {
            //Arrange 
            var nif = "A23456789";

            //Act
            var estaValido = Documento.ValidarNif(nif);

            //Assert 
            Assert.IsFalse(estaValido);
        }

    }
}


///Primeiro Escreve o Teste
///Segunda Fazer o teste falhar
///Corrige a Logica de Negócio
///---Teste vai passar
///Refatorar a lógicas