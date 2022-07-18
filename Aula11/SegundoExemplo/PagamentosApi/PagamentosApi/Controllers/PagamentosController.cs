using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PagamentosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentosController : ControllerBase
    {
        private List<Pagamento> pagamentos;

        [HttpGet]
        public List<Pagamento> GetPagamentos()
        {
            if (pagamentos == null)
            { 
                pagamentos = new List<Pagamento>();
                pagamentos.Add(new Pagamento { IBANOrigem = "1234", IBANDestino = "9999", DataDaOperacao = DateTime.Now, Valor = 10 });
            }            

            return pagamentos;
        }

        //[Route("/especial/{id}")]
        [HttpGet("especial")]
        public Pagamento GetPagamentosEspecial(int id)
        {
            if (pagamentos == null)
            {
                pagamentos = new List<Pagamento>();
            }
            var pagamentoSelecionado = pagamentos.FirstOrDefault(p => p.Id == id);

            return pagamentoSelecionado;
        }


        [HttpPost]
        public void NovoPagamento(Pagamento exemplo)
        {
            if (pagamentos == null)
            {
                pagamentos = new List<Pagamento>();                
            }
            pagamentos.Add(new Pagamento { IBANOrigem = "1234", IBANDestino = "9999", DataDaOperacao = DateTime.Now, Valor = 10 });
        }



        [HttpPut]
        public void AtualizarPagamento(int id, Pagamento exemplo)
        {
            if (pagamentos == null)
            {
                pagamentos = new List<Pagamento>();                
            }

            var pagamentoSelecionado = pagamentos.FirstOrDefault(p => p.Id == id);
            pagamentoSelecionado.DataDaOperacao = exemplo.DataDaOperacao;
            pagamentoSelecionado.Valor = exemplo.Valor;
        }


        [HttpDelete]
        public void ApagarPagamento(int id)
        {
            if (pagamentos == null)
            {
                pagamentos = new List<Pagamento>();
            }
            var pagamentoSelecionado = pagamentos.FirstOrDefault(p => p.Id == id);
            pagamentos.Remove(pagamentoSelecionado);            
        }
    }
}
