using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Repositorio
{
    public interface IRepositorio
    {
        public void Adicionar();

        public object Recuperar();


        public string Atualizar();


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
