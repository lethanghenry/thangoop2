using consoleApplication4.enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApplication4.dao
{
    class ProductDAO:BaseDAO,IDao
    {
        /// <summary>
        /// get Database
        /// </summary>
        private Database database = Database.GetInstance;
        private List<Product> listProduct = Database.GetListProduct;
       
    
      /// <summary>
      /// find Product by name
      /// </summary>
      /// <param name="name"></param>
      /// <returns>product</returns>
        public Product findByName(string name)
        {
            foreach (Product product in listProduct)
            {
                if (String.Compare(product.name,name)==0)
                {
                    return product;
                }
                break;
            }
            return null;
        }
        /// <summary>
        /// search Product by name
        /// </summary>
        /// <param name="where"></param>
        /// <returns>ListProduct</returns>
        public List<Product> search(string where)
        {
          List<Product> listSearch=  new List<Product>();
            foreach (Product product in listProduct)
            {
                if (String.Compare(product.name, where) == 0)
                {
                   listSearch.Add(product);
                   return listSearch;
                }
                break;
            }
            return listSearch;
        }

    }
}
