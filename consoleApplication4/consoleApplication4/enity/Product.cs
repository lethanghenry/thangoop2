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
    class Product:BaseRow
    {
       
        /// <summary>
        /// get set of categoryId
        /// </summary>
        public int categoryId { get; set; }

        /// <summary>
        /// constructor no param
        /// </summary>
        public Product()
        { }
        /// <summary>
        /// contructructor have param
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="categoryId"></param>
        public Product(int id, string name, int categoryId)
        {
            this.id = id;
            this.name = name;
            this.categoryId = categoryId;
        }
        /// <summary>
        /// return to String of attribute
        /// </summary>
        /// <returns></returns>
        public String toString()
        {
            return "\t" + this.id + "\t" + this.name + "\t" + this.categoryId;
        }
    }
}
