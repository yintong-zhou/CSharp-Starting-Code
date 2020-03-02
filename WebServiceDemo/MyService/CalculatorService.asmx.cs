using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MyService
{
    /// <summary>
    /// Descrizione di riepilogo per CalculatorService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Per consentire la chiamata di questo servizio Web dallo script utilizzando ASP.NET AJAX, rimuovere il commento dalla riga seguente. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculatorService : System.Web.Services.WebService
    {

        [WebMethod]
        public string Message()
        {
            return "Hello World!";
        }

        [WebMethod]
        public decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        [WebMethod]
        public decimal Sub(decimal a, decimal b)
        {
            return a - b;
        }

        [WebMethod]
        public decimal Mul(decimal a, decimal b)
        {
            return a * b;
        }

        [WebMethod]
        public decimal Div(decimal a, decimal b)
        {
            return a / b;
        }
    }
}
