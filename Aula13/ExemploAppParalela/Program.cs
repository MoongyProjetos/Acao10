using System.Linq;

var listaInteiros = Enumerable.Range(1, 1000000000);

var inicio = DateTime.Now;
foreach (var item in listaInteiros.AsParallel())
{
    if (item % 1000 == 0)
    {
        Console.WriteLine($"O multiplo encontrado foi: {item}");
    }
}
var final = DateTime.Now;


Console.WriteLine($"Levei {(final - inicio).Ticks} para executar");
//418872717
//412690416