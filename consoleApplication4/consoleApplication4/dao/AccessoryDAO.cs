using consoleApplication4.enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApplication4.dao
{
    class AccessoryDAO:BaseDAO, IDao
    {
    
        /// <summary>
        /// ovveride nameTable in BaseDao
        /// </summary>
        private  override string nameTable = "Accessory";
     

        /// <summary>
        /// Get list Accessoory to select
        /// Get select Table from Database Class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="where"></param>
        /// <returns>listAccessory </returns>
        public List<object> selectTableAccessoryTest(string where)
        {
            return database.selectTable("Accessory", where);
        }

        public void truncateTableAccessoryTest()
        {

        }
        public void initAccessoryDatabase()
        {
            for (int i = 0; i < 10; i++)
            {
                listAccessory[i].id = i + 20;
                listAccessory[i].name = (i + 20).ToString();
            }  
        }
    }  
}
