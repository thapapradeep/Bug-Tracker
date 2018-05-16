using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bug_Tracker.Forms.Model;
using Bug_Tracker.Forms.DB;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Bug_Tracker.Forms.DAO
{
    class UserDAO : GenericDAO<UserTable>
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserTable> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserTable GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(UserTable t)
        {
            OracleConnection conn = ConnectToDB.Connect();
            conn.Open();
            OracleCommand command= conn.CreateCommand();
            command.CommandText = "Insert into ASE.user_table(user_id, fname, lname, contact, address, username, password, type_id)" +
                "values(null, :Fname, :Lname, :Contact, :Address, :Username, :Password, :Type_id)";
            command.Parameters.Add(":Fname", t.fname);
            command.Parameters.Add(":Lname", t.lname);
            command.Parameters.Add(":Contact", t.contact);
            command.Parameters.Add(":Address", t.address);
            command.Parameters.Add(":username", t.username);
            command.Parameters.Add(":password", t.password);
            command.Parameters.Add(":type_id", t.type_id);
            int done = command.ExecuteNonQuery();
            return done;
           
        }

        public int Update(UserTable t)
        {
            throw new NotImplementedException();
        }
    }
}
