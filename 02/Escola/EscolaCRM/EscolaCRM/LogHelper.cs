using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;



namespace EscolaCRM
{
    public static class LogHelper
    {
       public static void EscreverLog(string mensagem)
        {
            var log = new StringBuilder();
            log.Append(DateTime.Now);
            log.Append(mensagem);

            File.AppendAllText(@"c:\temp\log.txt", log.ToString());
        }

        public static void ExemploMonitorPerformance()
        {


        }



    }
}
