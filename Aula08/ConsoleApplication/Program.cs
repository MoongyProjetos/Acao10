// See https://aka.ms/new-console-template for more information
using LogicaNegocio;
using Modelo;
using Modelo.Dados;
using Modelo.Infraestrutura;
using Modelo.Repositorio;
using System.Collections;


Console.WriteLine("Hello, World!");
Aluno.WriteLine("Hello, World!");


Documento.ValidarNif("123456789");

try
{
    var listaPessoas = new List<Pessoa>();

    var pedro = new Professor("Pedro da Silva");
    listaPessoas.Add(pedro);
    var hugo = new Professor("123456789", "Hugo da Silva", "Matematica");

    var luizinho = new Aluno();
    luizinho.ToString();
    listaPessoas.Add(luizinho);


    foreach (var pessoa in listaPessoas)
    {
        pessoa.ValidarDados();
        pessoa.ExibirDadosVirtual();
    }

}
catch (Exception ex)
{
    throw new EscolaException(ex);
}







Console.ReadLine();

return;




//Exemplo Modificador de Acesso
var pedrinho = new Aluno();
pedrinho.CodigoAluno = 10;
//pedrinho.Nota = 10;
//pedrinho.CampoProtegido = "";
//pedrinho.PropriedadeIniciadaNoConstrutor = "";



Aluno tiaguinho = new Aluno();
tiaguinho.CodigoAluno = 11;


var alice = new Aluno
{
    CodigoAluno = 10,
    DataCriacao = new DateTime(2019, 10, 10)
};


var aline = new Aluno("Aline");





var joao = new Professor();
joao.Sexo = Sexo.Masculino;
joao.Moradas = new List<Morada>();
joao.Moradas.Add(new Morada
{
    CodigoPostal = new CodigoPostal { Codigo = "2830", Complemento = "044" },
    NumeroPorta = "100",
    Rua = "Rua das Casas",
    TipoMorada = TipoMorada.Habitacao
});
joao.Moradas.Add(new Morada
{
    CodigoPostal = new CodigoPostal { Codigo = "2830", Complemento = "044" },
    NumeroPorta = "1",
    Rua = "Rua da Cobranca",
    TipoMorada = TipoMorada.Cobranca
});

Console.WriteLine(joao.Idade);


var maria = new Funcionario();
maria.Sexo = (Sexo)2;
maria.DiaDeFolga = DiasSemana.Domingo;




var joaozinho = new Aluno();
var mariazinha = new Aluno();
var ester = new Aluno();

var NovaTurma = new Turma();
NovaTurma.AlunosArray = new Aluno[50];

NovaTurma.AlunosArray[1] = joaozinho;
NovaTurma.AlunosArray[2] = mariazinha;
NovaTurma.AlunosArray[19] = ester; //Array comeca sempre com 0 [0][49]

NovaTurma.AlunosLista = new List<Aluno>();
NovaTurma.AlunosLista.Add(joaozinho);
NovaTurma.AlunosLista.Add(mariazinha);



NovaTurma.ObjetosArrayList = new ArrayList();
NovaTurma.ObjetosArrayList.Add(mariazinha);
NovaTurma.ObjetosArrayList.Add(maria);
NovaTurma.ObjetosArrayList.Add(new object());
NovaTurma.ObjetosArrayList.Add(new Agrupamento());

foreach (var item in NovaTurma.ObjetosArrayList)
{
    Console.WriteLine(item.ToString());
}


Aluno exemplo = (Aluno)NovaTurma.ObjetosArrayList[0];
//Aluno exemplo2 = (Aluno)NovaTurma.ObjetosArrayList[1]; //Erro


Console.WriteLine(NovaTurma.AlunosLista.Count);

NovaTurma.AlunosLista.Remove(mariazinha);
Console.WriteLine(NovaTurma.AlunosLista.Count);



var agrupamento = new Agrupamento();
agrupamento.Distrito = new Dictionary<string, string>();
agrupamento.Distrito.Add("LIS", "Lisboa");
agrupamento.Distrito.Add("STB", "Setúbal");
agrupamento.Distrito.Add("PRT", "Porto");


agrupamento.Distrito.TryGetValue("LIS", out string exemploDicionario);






Console.ReadLine();