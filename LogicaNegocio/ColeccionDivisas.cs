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
        protected override string GetKeyForItem(Divisa item)
        {
            return item.Nombre;
        }
    }
}
