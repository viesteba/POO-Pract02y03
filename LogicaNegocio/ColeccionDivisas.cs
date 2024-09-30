using ModeloDominio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class ColeccionDivisas : KeyedCollection<string, Divisa>
    {
        /// <summary>
        /// item is a Divisa
        /// </summary>
        /// <param name="item"></param>
        /// <returns>the name of Divisa</returns>
        protected override string GetKeyForItem(Divisa item)
        {
            return item.Nombre;
        }
    }
}
