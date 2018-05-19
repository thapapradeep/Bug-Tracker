using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bug_Tracker.Forms.DAO
{
    /// <summary>
    /// Generic Class
    /// </summary>
    /// <typeparam name="T"></typeparam>
   public  interface GenericDAO<T>
    {
        /// <summary>
        /// Method to inseert into database
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        int Insert(T t );

        /// <summary>
        /// Method to update data
        /// </summary>
        /// <param name="t"></param>
        int Update(T t);

        /// <summary>
        /// Method to delete data
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        bool Delete(int id);

        /// <summary>
        /// Retriving all data from database
        /// </summary>
        /// <returns></returns>

        List<T> GetAll();

        /// <summary>
        /// selecting data by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        T GetById(int id);
        
    
       

    }
}
