using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApplication4.enity
{
    /// <summary>
    /// inheritance from BaseRow
    /// </summary>
    class Category:BaseRow
    {

        /// <summary>
        /// constructor no param
        /// </summary>
        public Category()
        { }
        
       /// <summary>
       /// contructor have param
       /// </summary>
       /// <param name="id"></param>
       /// <param name="name"></param>
        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        /// <summary>
        /// return to string 
        /// </summary>
        /// <returns></returns>
        public String toString()
        {
            return "\t" + this.id + "\t" + this.name;
        }
    }
}
