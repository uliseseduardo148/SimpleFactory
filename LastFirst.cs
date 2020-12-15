using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class LastFirst : Namer
    {
        /*Esta clase recibe un string como parámetro, si en la cadena se detecta ","
        * parte esa cadena a partir de ese caracter e invierte el orden de los datos
        */
        public LastFirst(string name)
        {
            int i = name.IndexOf(",");
            if (i > 0)
            {
                lastName = name.Substring(0, i);
                firstName = name.Substring(i + 1).Trim();
            } else
            {
                lastName = name;
                firstName = "";
            }
        }
    }
}
