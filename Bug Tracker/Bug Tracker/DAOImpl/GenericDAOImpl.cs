using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bug_Tracker.Forms.DAO;


namespace Bug_Tracker.Forms.DAOImpl
{
    abstract class GenericDAOImpl<T> : GenericDAO<T>
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(T t)
        {
            throw new NotImplementedException();
        }

        public int Update(T t)
        {
            throw new NotImplementedException();
        }
    }
}
