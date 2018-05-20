using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bug_Tracker.Forms.Model;
using Oracle.ManagedDataAccess.Client;
using Bug_Tracker.Forms.DB;

namespace Bug_Tracker.Forms.DAO
{
    public class UserAssignDAO : GenericDAO<UserAssign>
    {
        OracleConnection conn = ConnectToDB.Connect();
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserAssign> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserAssign GetById(int id)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Inserts data into User Assign table 
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Insert(UserAssign t)
        {
            int done = 0;
            try
            {
                conn.Open();
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "insert into ASE.user_assign(user_id,bug_id, assigned_by, description)" +
                    "values(:user_id,:bug_id, :assigned_by, :description)";
                command.Parameters.Add(":user_id", t.user_id);
                command.Parameters.Add(":bug_id", t.bug_id);
                command.Parameters.Add(":assigned_by", t.assigned_by);
                command.Parameters.Add(":description", t.description);

                done = command.ExecuteNonQuery();
                
           }
            catch(Exception ex)
            {

            }
            return done;
            }




        public int Update(UserAssign t)
        {
            throw new NotImplementedException();
        }
    }
}
