using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.Reflection;

namespace Demo_Log4Net
{
    class Program
    {
        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            try
            {
                int zero = 0;
                int resultado = 5 / zero;
                logger.Info("El resultado es: " + resultado);
            }
            catch (Exception ex)
            {
                logger.Error("Error: ", ex);
            }
        }
    }
}
