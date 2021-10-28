using consoleApplication4.dao;
using consoleApplication4.enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApplication4.demo
{
    class ProductDaoDemo
    {
        private Database database = Database.GetInstance;
        /// <summary>
        /// insert Product
        /// get insert table from database
        /// </summary>
        public void insertTableProductTest()
        {
            object product = new Product(2, "An", 5);
            database.insertTable("Product", product);

        }
        /// <summary>
        /// select product
        /// get select table from database
        /// </summary>
        public void selectTableProductTest()
        {
            List<Object> listProduct = database.selectTable("Product", "An");
            foreach (Product p in listProduct)
            {
                Console.WriteLine(p);
            }
        }
        /// <summary>
        /// update product
        /// get updatetable from database
        /// </summary>
        public void updateTableProductTest()
        {
            object product = new Product(2, "An", 5);
            database.updateTable("Product", product);

        }
        /// <summary>
        /// delete product
        /// get deleteTable from database
        /// </summary>
        public void deleteTableProductTest()
        {

            object product = new Product(2, "An", 5);
            database.deleteTable("Product", product);
        }
        /// <summary>
        /// truncate Product
        /// get truncateTable from database
        /// </summary>
        public void truncateTableProductTest()
        {
            database.truncateTable("Product");
        }
    }
}
