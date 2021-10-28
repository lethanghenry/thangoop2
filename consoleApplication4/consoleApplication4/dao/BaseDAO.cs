using consoleApplication4.enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApplication4.dao
{
    abstract class BaseDAO
    {
        /// <summary>
        /// get database from Database class
        /// </summary>
        protected Database database = Database.GetInstance;
        protected List<Product> listProduct = Database.GetListProduct;
        protected List<Accessory> listAccessory = Database.GetListAccessory;
        protected List<Category> listCategory = Database.GetListCategory;
        /// <summary>
        /// nameTable to param name in many function
        /// </summary>
        protected string nameTable = "Product";

        /// <summary>
        /// insert table
        /// insertTable from database
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public int insert(object row)
        {

            return database.insertTable(nameTable, row);
        }
        /// <summary>
        /// update table
        /// </summary>
        /// <param name="row"></param>
        /// <returns>list Object</returns>

        public int update(object row)
        {
            return database.updateTable(nameTable, row);
        }
        public Boolean delete(object row)
        {
            return database.deleteTable(nameTable, row);
        }

        public List<object> findAll()
        {
            return database.findAll(nameTable);
        }
        public object findById(int id)
        {
           return database.findById(nameTable, id);
        }

    }
}
