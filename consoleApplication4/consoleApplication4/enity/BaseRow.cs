using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApplication4.enity
{
   abstract class BaseRow:IEnity
    {
        public  int id { get; set; }
        public  string name { get; set; }


    }
}
