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

        public Divisa(string name, double value)
        {
            this.nombre = name;
            this.valor = value;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public bool Equals(Divisa divisa)
        {
            return (this.nombre.Equals(divisa.nombre) && this.valor.Equals(divisa.valor));
        }
        public string ToString()
        {
            return this.nombre + "- " + this.valor;
        }
    }
}
