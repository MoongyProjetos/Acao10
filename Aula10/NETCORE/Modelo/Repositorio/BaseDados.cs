using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Repositorio
{
    public class BaseDados : IRepositorio<string, int>
    {
        public void Adicionar(string item)
        {
            throw new NotImplementedException();
        }

        public string Atualizar(int item)
        {
            throw new NotImplementedException();
        }

        public string Recuperar(int id)
        {
            throw new NotImplementedException();
        }

        public List<string> Recuperar(int id, int qtd)
        {
            throw new NotImplementedException();
        }
    }
}
