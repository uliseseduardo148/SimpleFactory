using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class NameFactory
    {
        /*Esta clase mediante el método getName retorna una u otra clase dependiendo de la
        * cadena introducida por el usuario, si dentro de ella existe ',' retorna una instancia
        *  de la clase LastFirst, sino una del tipo FirstFirst
        */
        public NameFactory() { }
        public static Namer getName(string name)
        {
            int i = name.IndexOf(",");
            if (i > 0)
                return new LastFirst(name);
            else
                return new FirstFirst(name);
        }
    }
}
