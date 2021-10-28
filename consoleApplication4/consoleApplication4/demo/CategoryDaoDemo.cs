using consoleApplication4.dao;
using consoleApplication4.enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApplication4.demo
{
    class CategoryDaoDemo
    {
        // get database
        private Database database = Database.GetInstance;
        /// <summary>
        /// insert Category table
        /// </summary>
        public void insertTest()
        {
            object category = new Category(1, "thang");
            database.insertTable("Category", category);
        }
        public void findAllTest()
        { }
        /// <summary>
        /// udate Category table
        /// </summary>
        public void updateTest()
        {
            object category = new Category(1, "thang dep zai");
            database.updateTable("Category", category);
        }
    }
}
