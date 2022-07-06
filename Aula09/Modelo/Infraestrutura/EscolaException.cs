using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Infraestrutura
{
    public class EscolaException : Exception
    {
        public EscolaException() : base()
        {
            File.WriteAllText(@"c:\temp\log.txt", Message);
        }

        public EscolaException(string mensagem) : base(mensagem)
        {
            //Muito cuidado com isso.
            File.WriteAllText(@"c:\temp\log.txt", Message);
        }

        public EscolaException(Exception ex) : base()
        {
            //Muito cuidado com isso.
            File.WriteAllText(@"c:\temp\log.txt", Message);
        }
    }
}
