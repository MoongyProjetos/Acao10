// See https://aka.ms/new-console-template for more information
using System.Text.Json;



Console.WriteLine("Hello, World!");


Console.ReadLine();

HttpClient client = new HttpClient();
client.BaseAddress = new Uri("https://localhost:7148/api/Pagamentos");
var response = client.GetAsync(client.BaseAddress).Result;
var json = response.Content.ReadAsStringAsync().Result;


var pagamentos = JsonSerializer.Deserialize<List<Pagamento>>(json);


Console.WriteLine(json);
Console.ReadLine();