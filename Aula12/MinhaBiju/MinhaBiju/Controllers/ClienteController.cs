using Microsoft.AspNetCore.Mvc;
using MinhaBiju.Models;

namespace MinhaBiju.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult ListagemDeClientes()
        {
            return View();
        }

        public IActionResult ListagemDeClientesPassandoDadosDoDB()
        {
            var listaCliente = new List<Cliente>();
            listaCliente.Add(new Cliente { Nome = "Fulano", DataNascimento = new DateTime(2000, 01, 01) });
            listaCliente.Add(new Cliente { Nome = "Beltrano", DataNascimento = new DateTime(2000, 01, 01) });
            return View(listaCliente);
        }


        public IActionResult CriarNovoCliente()
        {
            return View();
        }
    }
}
