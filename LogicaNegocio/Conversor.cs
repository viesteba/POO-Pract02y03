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
        /// <summary>
        /// divRef está en la colección de divisas
        /// </summary>
        /// <param name="divRef"></param>
        /// <param name="divisas"></param>
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
        /// <summary>
        /// d es una divisa
        /// </summary>
        /// <param name="d"></param>
        /// <returns>devuelve true si la divisa está en la colección y falso en otro caso</returns>
        public bool ExisteDivisa(Divisa d)
        {
            return divisas.Contains(d);
        }
        /// <summary>
        /// nomDiv es una cadena
        /// </summary>
        /// <param name="nomDiv"></param>
        /// <returns>devuelve true si hay una divisa con ese nombre en la colección</returns>
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
        /// existe una divisa en colección divisas con nombre nomDiv
        /// </summary>
        /// <param name="nomDiv"></param>
        /// <returns>devuelve la divisa de la colección que tiene ese nombre</returns>
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
        /// <summary>
        /// muestra los nombres de las divisas disponibles
        /// </summary>
        public void ColeccionClaves()
        {
            foreach (Divisa d in divisas)
            {
                Console.WriteLine(d.ToString());
            }
        }
        /// <summary>
        /// proporciona una propiedad para obtener la colección de divisas
        /// </summary>
        public ColeccionDivisas ColeccionDivisas
        {
            get { return this.ColeccionDivisas; }
        }
    }
}
