using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class FirstFirst : Namer
    {
        /*Esta clase recibe un string como parámetro, si en la cadena se detecta espacio
         * parte esa cadena a partir del caracter " "
         */
        public FirstFirst(string name)
        {
            int i = name.IndexOf(" ");
            if (i > 0)
            {
                firstName = name.Substring(0, i).Trim();
                lastName = name.Substring(i + 1).Trim();
            }
            else
            {
                lastName = name;
                firstName = "";
            }
        }
    }
}
