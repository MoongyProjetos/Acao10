<Query Kind="Program" />

void Main()
{
	var segurado = new List<Seguro>();
	
	segurado.Add(new SeguroAuto{Matricula = "1234"});
	segurado.Add(new SeguroVida{Idade = 10});
	segurado.Add(new SeguroCasa{Morada = "Rua das Casas ..."});
	
	foreach (var element in segurado)
	{
		element.Pagar(10);
		element.CalcularValorPremio().Dump();
		element.Imprimir();
	}	
}

abstract class Seguro : IPagamento{
	public string Identificacao {get;set;}

	public abstract void Pagar(decimal dinheiro);	
	public decimal CalcularValorPremio(){return 15;}//Método concreto
	
	public virtual void Imprimir(){
		Console.WriteLine("IMpressao básica");
	}
	
	public virtual void Exemplo(){}
}

//final
sealed class  SeguroAuto : Seguro{
	public string Matricula {get;set;}
	public override void Pagar(decimal dinheiro)
	{
		Console.WriteLine("Paguei seguro auto");
	}

	public override void Exemplo()
	{
		base.Exemplo();
	}
}


sealed class SeguroCasa : Seguro
{
	public string Morada { get; set; }
	public override void Pagar(decimal dinheiro)
	{
		Console.WriteLine("Paguei Seguro casa");
	}
}



class SeguroVida: Seguro
{
	public int Idade { get; set; }
	public override void Pagar(decimal dinheiro)
	{
			Console.WriteLine("Paguei seguro vida"); 
	}

	public override void Imprimir()
	{
		Console.WriteLine("Impressao especial do seguro de vida");
	}
}

interface IPagamento{
	void Pagar(decimal dinheiro);
}








