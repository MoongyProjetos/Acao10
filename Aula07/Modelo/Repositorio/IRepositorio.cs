using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Repositorio
{
    //where é para limitar os tipos genéricos
    //no exemplo, aceitamos apenas classes
    public interface IRepositorio <T, U> where T: class
    {
        public void Adicionar(T item);
        public T Recuperar(U id);
        public List<T> Recuperar(U id, int qtd);
        public T Atualizar(U item);


        /// <summary>
        /// C# 8.0 - Def
        /// TODO: Verificar como isso se comporta
        /// </summary>
        /// <returns></returns>
        public string MetodoComDefault()
        {
            return "Exemplo";
        }
    }
}
