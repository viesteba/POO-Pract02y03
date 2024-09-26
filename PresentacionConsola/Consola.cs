using LogicaNegocio;
using ModeloDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentacionConsola
{
    public class Consola
    {
        private Conversor conversor;

        public Consola(Conversor conversor)
        {
            this.conversor = conversor;
        }
        public void Menu()
        {
            String s1;
            String s2;
            do
            {
                Console.WriteLine("Introduce la divisa original: ");
                s1 = Console.ReadLine();
            } while (!this.conversor.ExisteDivisa(s1));

            Divisa d1 = this.conversor.GetDivisa(s1);

            do
            {
                Console.WriteLine("Introduce la divisa a cambiar: ");
                s2 = Console.ReadLine();
            } while (!this.conversor.ExisteDivisa(s2));

            Divisa d2 = this.conversor.GetDivisa(s2);

            Console.WriteLine("Introduce la cantidad a convertir: ");
            String c = Console.ReadLine();
            double cant = double.Parse(c);
            Console.WriteLine(conversor.Convertir(d1, d2, cant));

        }
    }
}
