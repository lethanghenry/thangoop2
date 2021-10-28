using consoleApplication4.enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApplication4.dao
{
    class Database
    {

        public List<object> productTable();
        public List<object> categoryTable();
        public List<object> accessoryTable();

        /// <summary>
        /// get database by singleton
        /// </summary>
        private static Database instance=null;
        public static Database GetInstance
        {
            get
            {
                if(instance==null)
                {
                    instance = new Database();

                }
                return instance;
            }
        }
        /// <summary>
        /// get list product
        /// </summary>
        private static List<Product> listProduct = null;

        public static List<Product> GetListProduct
        {
            get
            {
                if(listProduct==null)
                {
                    listProduct = new List<Product>();
                }
                return listProduct;
            }
        }

        /// <summary>
        /// get list Accessory
        /// </summary>
        private static List<Accessory> listAccessory = null;
        public static List<Accessory> GetListAccessory
        {
            get
            {
                if (listAccessory == null)
                {
                    listAccessory = new List<Accessory>();
                }
                return listAccessory;
            }
        }

        /// <summary>
        /// get list Category
        /// </summary>
        private static List<Category> listCategory = null;
        public static List<Category> GetListCategory
        {
            get
            {
                if (listCategory == null)
                {
                    listCategory = new List<Category>();
                }
                return listCategory;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="row">object</param>
        /// <returns>list.Count</returns>
        public int insertTable(string name, object row)
        {
            if (String.Compare(name, "Category") == 0)
            {
                Category category = (Category)row;
                listCategory.Add(category);
                return listCategory.Count;
            }
            else if (String.Compare(name, "Product") == 0)
            {
                Product product = (Product)row;
                listProduct.Add(product);
                return listProduct.Count;
            }
            else if (String.Compare(name, "Accessory") == 0)
            {
                Accessory accessory = (Accessory)row;
                listAccessory.Add(accessory);
                return listAccessory.Count;
            }
            return 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="row"></param>
        /// <returns>id or 0</returns>
       
        public int updateTable(string name, object row)
        {
            if (String.Compare(name, "Product") == 0)
            {
                Product product = (Product)row;
                foreach (Product p in listProduct)
                {
                    if (p.id == product.id)
                    {
                        p.name = product.name;
                        p.categoryId = product.categoryId;
                        return p.id;
                    }
                    else
                    {
                        return 0;
                    }
                }


            }
            else if (String.Compare(name, "Accessory") == 0)
            {
                Accessory accessory = (Accessory)row;
                foreach (Accessory a in listAccessory)
                {
                    if (a.id == accessory.id)
                    {
                        a.name = accessory.name;
                        return a.id;
                    }
                    else
                    {
                        return 0;
                    }
                }

            }
            else if (String.Compare(name, "Category") == 0)
            {
                Category category = (Category)row;
                foreach (Category c in listCategory)
                {
                    if (c.id == category.id)
                    {
                        c.name = category.name;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            return 0;
        }

         public Boolean deleteTableProduct(object row)
         {
             Product product = (Product)row;
             foreach(Product p in listProduct)
             {
                 if(p.id==product.id)
                 {
                     listProduct.Remove(p);
                     return true;
                 }
                 return false;
             }
             return false;
         }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="row"></param>
        /// <returns>if delete -> true else false</returns>
        
       
        public Boolean deleteTable(string name, object row)
        {
            if (String.Compare(name, "Category") == 0)
            {
                Category category = (Category)row;
                foreach (Category c in listCategory)
                {
                    if (c.id == category.id)
                    {
                        listCategory.Remove(c);
                        return true;
                    }
                    else
                        return false;
                }
            }
            else
                if (String.Compare(name, "Product") == 0)
                {
                    Product product = (Product)row;
                    foreach (Product p in listProduct)
                    {
                        if (p.id == product.id)
                        {
                            listProduct.Remove(p);
                            return true;
                        }
                        else return false;
                    }
                }
                else
                    if (String.Compare(name, "Accessory") == 0)
                    {
                        Accessory accessory = (Accessory)row;
                        foreach (Accessory a in listAccessory)
                        {
                            if (a.id == accessory.id)
                            {
                                listAccessory.Remove(a);
                                return true;
                            }
                            else
                                return false;
                        }
                    }
            return false;
        }

        /// <summary>
        /// delete all data
        /// </summary>
        /// <param name="name"></param>
        public void truncateTable(string name)
        {
            if(String.Compare(name,"Product")==0)
            {
                listProduct.Clear();
            }
            else if (String.Compare(name, "Accessory") == 0)
            {
                listAccessory.Clear();
            }
            else if (String.Compare(name, "Category") == 0)
            {
                listCategory.Clear();
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="row"></param>
        /// <returns>list product or category or accessory</returns>
        public List<object> selectTable(string name, string where)
        {
            List<Category> listCategorySelect = new List<Category>();
            List<Accessory> listAccessorySelect = new List<Accessory>();
            List<Product> listProductSelect = new List<Product>();
            if (String.Compare(name, "Category") == 0)
            {
                foreach (Category c in listCategory)
                {
                    if (String.Compare(c.name, where) == 0)
                    {
                        listCategorySelect.Add(c);

                    }
                }
                return listAccessorySelect.Cast<Object>().ToList();
            }
            else if (String.Compare(name, "Accessory") == 0)
            {
                foreach (Accessory a in listAccessory)
                {
                    if (String.Compare(a.name, where) == 0)
                    {
                        listAccessorySelect.Add(a);
                    }
                }
                return listAccessorySelect.Cast<Object>().ToList();
            }
            else if (String.Compare(name, "Product") == 0)
            {
                foreach (Product p in listProductSelect)
                {
                    if (String.Compare(p.name, where) == 0)
                    {
                        listProductSelect.Add(p);
                    }
                }
                return listProductSelect.Cast<Object>().ToList();
            }
            return null;

        }

        /// <summary>
        /// Get List from Product, Accessory, Category
        /// </summary>
        /// <param name="name"></param>
        /// <returns>object</returns>
        public List<object> findAll(string name)
        {
            if(String.Compare(name,"Product")==0)
            {
                return GetListProduct.Cast<object>().ToList();
            }
            else if(String.Compare(name,"Accessory")==0)
            {
                return GetListAccessory.Cast<object>().ToList();
            }
            else if(String.Compare(name,"Category")==0)
            {
                return GetListCategory.Cast<object>().ToList();
            }
            return null;
        }

        /// <summary>
        /// find object from id of 3 enity class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <returns>object</returns>
        public object findById(string name, int id)
        {
            if(String.Compare(name,"Product")==0)
            {
              
                foreach(Product product in listProduct)
                {
                    if(product.id==id)
                    {
                        return product;
                    }
                }
                
            }
            else if(String.Compare(name,"Accessory")==0)
            {
               
                foreach(Accessory accessory in listAccessory)
                {
                    if(accessory.id==id)
                    {
                        return accessory;
                    }
                }
                
            }
            else if(String.Compare(name,"Category")==0)
            {
               
                foreach(Category category in listCategory)
                {
                    if(category.id==id)
                    {
                        return category;
                    }
                }
               
            }
            return null;
        }

        public List<object> Get { get; set; }
    }
}
