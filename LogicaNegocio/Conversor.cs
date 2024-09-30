using ModeloDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Conversor
    {
        private Divisa divRef;
        private ColeccionDivisas divisas;

        public Conversor(Divisa divRef, ColeccionDivisas divisas)
        {
            this.divRef = divRef;
            this.divisas = divisas;
        }
        /// <summary>
        /// d1,d2 son divisas y cant es no negativa
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <param name="cant"></param>
        /// <returns>convierte el precio en d1, al precio en d2</returns>
        public double Convertir(Divisa d1, Divisa d2, double cant)
        {
            return cant * d2.Valor / d1.Valor;
        }
        public bool ExisteDivisa(Divisa d)
        {
            return divisas.Contains(d);
        }
        public bool ExisteDivisa(string nomDiv)
        {
            bool existe = false;
            foreach (Divisa d in divisas)
            {
                if (d.Nombre == nomDiv)
                {
                    existe = true;
                }
            }
            return existe;
        }
        /// <summary>
        /// existe la divisa
        /// </summary>
        /// <param name="nomDiv"></param>
        /// <returns></returns>
        public Divisa GetDivisa(string nomDiv)
        {
            Divisa divisa = null;
            foreach (Divisa d in divisas)
            {
                if (d.Nombre == nomDiv)
                {
                    divisa = d;
                }
            }
            return divisa;
        }
        public void ColeccionClaves()
        {
            foreach (Divisa d in divisas)
            {
                Console.WriteLine(d.ToString());
            }
        }
        public ColeccionDivisas ColeccionDivisas
        {
            get { return this.ColeccionDivisas; }
        }
    }
}
