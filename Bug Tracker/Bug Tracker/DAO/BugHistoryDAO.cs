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
   public class BugHistoryDAO : GenericDAO<BugHistory>
    {
        OracleConnection conn = ConnectToDB.Connect();
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<BugHistory> GetAll()
        {
            throw new NotImplementedException();
        }

        public BugHistory GetById(int id)
        {
            throw new NotImplementedException();

        }

        public int Insert(BugHistory t)
        {
            
            conn.Open();
            OracleCommand command = conn.CreateCommand();
            command.CommandText = "insert into ASE.bug_history(id, bug_id, user_id, attemped_date, status, code_block)" +
                "values(null,:bug_id, :user_id, current_timestamp, :status, :code_block)";
            command.Parameters.Add("bug_id", t.bug_id);
            command.Parameters.Add("user_id", t.user_id);
            command.Parameters.Add(":status", t.status);
            command.Parameters.Add("cose_block", t.code_block);
            int done = command.ExecuteNonQuery();
            return done;

        }

        public int Update(BugHistory t)
        {
            throw new NotImplementedException();
        }

        public String GetCodeBlock(BugHistory h)
        {
            String code = null;
            conn.Open();
            OracleCommand command = conn.CreateCommand();
            command.CommandText = "select code_block from ASE.bug_history where id=:id ";
            command.Parameters.Add(":id", h.id);
            
            OracleDataReader data = command.ExecuteReader();
            if (data.HasRows)
            {
                while (data.Read())
                {
                    code = data.GetString(0);
                }
            }
            return code;
        }
    }
}
