// See https://aka.ms/new-console-template for more information
using ProgramacaoAssincrona;

Console.WriteLine("Hello, World!");



var exemplos = new Exemplos();
exemplos.ExemploMetodoSincrono();


Task.Run(() => exemplos.ExemploMetodoAssincrono());
Task.Run(() => exemplos.ExemploMetodoAssincronoComLista());

await exemplos.ExemploMetodoAssincronoComLista();


//TUDO é importante e tem que esperar por todos
//Exemplo: transferencia bancária
Task.WaitAll(
    exemplos.ExemploMetodoAssincronoComLista(), //Invocando débito do MilleniumBCP
    exemplos.ExemploMetodoAssincronoComLista(),   //Invocando depósito do BPI,
    Task.Run(() => Console.WriteLine("Estou executando"))
    );
    


//Assim que o primeiro terminar, libera a tela para o usuário
//Exemplo lista de relatórios
Task.WaitAny(
    exemplos.ExemploMetodoAssincronoComLista(), //Invocando débito do MilleniumBCP
    exemplos.ExemploMetodoAssincronoComLista(),  //Invocando depósito do BPI
    Task.Run(() => Console.WriteLine("Executei pelo menos 1"))
    );








exemplos.ExemploMetodoSincronoListagemPessoas();



//Task.Run(() => exemplos.ExemploMetodoAssincrono());

