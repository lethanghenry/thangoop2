using consoleApplication4.enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApplication4.dao
{
    class CategoryDAO:BaseDAO,IDao
    {
        private override string nameTable = "Category";
        /// <summary>
        /// Get database from Database class
        /// </summary>
        private Database database = Database.GetInstance;
        /// <summary>
        /// Get list Category from Database
        /// </summary>
        private List<Category> listCategory = Database.GetListCategory;
       
       
      
    }
}
