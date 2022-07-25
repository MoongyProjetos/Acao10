using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoAssincrona
{
    public interface IContrato
    {
        Task ExemploMetodoAssincrono();
        Task<List<PessoaDTO>> ExemploMetodoAssincronoComLista();

        void ExemploMetodoSincrono();
        List<PessoaDTO> ExemploMetodoSincronoListagemPessoas();
    }
}
