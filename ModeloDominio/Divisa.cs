using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Divisa : IEquatable<Divisa>
    {
        private string nombre;
        private double valor;
        /// <summary>
        /// value es un valor no negativo
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public Divisa(string name, double value)
        {
            this.nombre = name;
            this.valor = value;
        }
        /// <summary>
        /// permite obtener el nombre de la divisa
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
        }
        /// <summary>
        /// permite consultar el valor de la divisa con respecto a la divisa de referencia
        /// </summary>
        public double Valor
        {
            get { return valor; }
        }
        /// <summary>
        /// divisa está inicializada
        /// </summary>
        /// <param name="divisa"></param>
        /// <returns>devuelve true si son la misma divisa, i.e. comparten el mismo nombre</returns>
        public bool Equals(Divisa divisa)
        {
            if (divisa == null)
            {
                return this == null;
            }
            else
            {
                return (this.nombre.Equals(divisa.nombre));
            }
        }
        /// <summary>
        /// divisa ha sido inicializada
        /// </summary>
        /// <returns>dvuelve la información de la divisa</returns>
        public string ToString()
        {
            return this.nombre + "- " + this.valor;
        }
    }
}
