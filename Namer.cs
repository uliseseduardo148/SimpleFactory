using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
   public class Namer
    {
        protected string firstName, lastName;
        public string getFrname()
        {
            return firstName;
        }
        public string getLname()
        {
            return lastName;
        }  
    }
}
