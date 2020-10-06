using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppTask1_17597280
{
   
    public class ListofCallNumbers
    {
        private String Calnumbers;

        public ListofCallNumbers(string calnumbers)
        {
            Calnumbers = calnumbers;
        }

        public string Calnumbers1 { get => Calnumbers; set => Calnumbers = value; }
    }
}
