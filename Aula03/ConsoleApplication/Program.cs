// See https://aka.ms/new-console-template for more information
using Modelo;

Console.WriteLine("Hello, World!");



var joao = new Pessoa();
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

