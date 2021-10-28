using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApplication4.dao
{
    interface IDao
    {
        /// <summary>
        /// insert table
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public int insert(object row);

        /// <summary>
        /// update table
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public int update(object row);

        /// <summary>
        /// delete table
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public Boolean delete(object row);

        /// <summary>
        /// find All
        /// </summary>
        /// <returns>listObject</returns>
        public List<object> findAll();
        /// <summary>
        /// find object by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>return id</returns>
        public object findById(int id);
    }
}
