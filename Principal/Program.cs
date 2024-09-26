using LogicaNegocio;
using ModeloDominio;
using PresentacionConsola;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Divisa divRef = new Divisa("dólar", 1);
            Divisa div1 = new Divisa("euro", 1.11);
            Divisa div2 = new Divisa("libra", 1.34);
            Divisa div3 = new Divisa("peso dominicano", 0.017);
            Divisa div4 = new Divisa("franco suizo", 1.18);
            ColeccionDivisas colDiv = new ColeccionDivisas();
            colDiv.Add(divRef);
            colDiv.Add(div1);
            colDiv.Add(div2);
            colDiv.Add(div3);
            colDiv.Add(div4);
            Conversor conversor = new Conversor(divRef,colDiv);
            Consola c = new Consola(conversor);
            c.Menu();
            Console.ReadLine();
        }
    }
}
