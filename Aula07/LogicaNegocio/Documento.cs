using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public static class Documento
    {
        public static bool ValidarNif(string nif)
        {
            var resultado = true;
            if(nif.Length != 9)
            {
                resultado = false;
            }

            for (int i = 0; i < nif.Length; i++)
            {
                if (!char.IsDigit(nif[i]))
                {
                    resultado = false;
                }
            }

            return resultado;
        }
    }
}
