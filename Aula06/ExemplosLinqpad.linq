<Query Kind="Program" />

void Main()
{
	var contador = 1000000;
	
	var listaExemplo = new List<Exemplo>();
	for (int i = 0; i < contador; i++)
	{
		if(i == 1000)
			listaExemplo.Add(new Exemplo{Identificador = i, DataCriacao = DateTime.Now, Nome = ""});
		else
			listaExemplo.Add(new Exemplo{Identificador = i, DataCriacao = DateTime.Now, Nome = "Nome exemplo " + i});
		//Thread.Sleep(1);
	}

	listaExemplo
	.OrderByDescending(x => x.Identificador)
	.Where(bata => String.IsNullOrWhiteSpace(bata.Nome))
	.Take(2)	
	.Select(x => new {x.Identificador, x.DataCriacao}).Dump("Playground");
	
	listaExemplo.Max(e => e.DataCriacao).Dump("Mais novo");



	var inicio = DateTime.Now;
	listaExemplo.Skip(800).Where(x => x.Identificador % 15 == 0 && x.Identificador != 0).Take(5).Dump("Expressao Lambda");
	var final = DateTime.Now;
	(final - inicio).Ticks.Dump();
	
	
	var inicioAntigo = DateTime.Now;
	var acumulador = new List<Exemplo>();
	foreach (var element in listaExemplo)
	{
		if( element.Identificador >= 800 && 
			element.Identificador % 15 == 0 && 
			element.Identificador != 0 && 
			acumulador.Count < 5)
		{
			acumulador.Add(element);
		}
	}
	acumulador.Dump("Foreach comum");
	var finalAntigo = DateTime.Now;
	(finalAntigo - inicioAntigo).Ticks.Dump();
}


class Exemplo{
	public int Identificador { get; set; }
	public string Nome { get; set; }
	public DateTime DataCriacao { get; set; }
}


// You can define other methods, fields, classes and namespaces here