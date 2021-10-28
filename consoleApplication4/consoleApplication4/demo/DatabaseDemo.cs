using consoleApplication4.dao;
using consoleApplication4.enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApplication4.demo
{
    class DatabaseDemo
    {

      private  Database database = Database.GetInstance;
        List<Product> listProduct = Database.GetListProduct;
        List<Accessory> listAccessory = Database.GetListAccessory;
        List<Category> listCategory = Database.GetListCategory;

        /// <summary>
        /// 
        /// </summary>
        public void insertTableTest()
        {
            object category = new Category(1,"Thang");
            object product = new Product(2, "An", 5);
            object accessory = new Accessory(3, "Kim");

            database.insertTable("Category", category);
            database.insertTable("Product", product);
            database.insertTable("Accessory", accessory);
            
        }
        /// <summary>
        /// select table where name data and row
        /// </summary>
        public void selectTableTest() 
        {

            List<Object> listCategory = database.selectTable("Category", "thang");
            List<Object> listProduct = database.selectTable("Product", "An");
            List<Object> listAccessory = database.selectTable("Accessory", "kim");
            foreach (Product p in listProduct)
            {
                Console.WriteLine(p);
            }
            foreach (Accessory a in listAccessory)
            {
                Console.WriteLine(a);
            }
            foreach (Category c in listCategory)
            {
                Console.WriteLine(c);
            }
        }

        /// <summary>
        /// update tablle where name data and row
        /// </summary>
        public void updateTableTest()
        {

            object category = new Category(1, "nam");
            object product = new Product(2, "An", 5);
            object accessory = new Accessory(3, "kim");


            database.updateTable("Category", category);
            database.updateTable("Product", product);
            database.updateTable("Accessory", accessory);
        }
        public void deleteTableTest()
        { }
        public void truncateTableTest()
        {

        }
        /// <summary>
        /// add data from 3 class enity 
        /// accessory
        /// category
        /// product
        /// </summary>
        public void initDatabase()
        {
            for (int i = 0; i < 10; i++)
            {
                listProduct[i].id = i;
                listProduct[i].name = i.ToString();
                listProduct[i].categoryId = i * 10;
            }
            for (int i = 0; i < 10; i++)
            {
                listCategory[i].id = i + 10;
                listCategory[i].name = (i + 10).ToString();
            }
            for (int i = 0; i < 10; i++)
            {
                listAccessory[i].id = i + 20;
                listAccessory[i].name = (i + 20).ToString();
            }  
        }
        public void printTableTest()
        { }
    }
}
