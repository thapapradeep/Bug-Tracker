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
    class BugDAO : GenericDAO<Bug>

    {
        OracleConnection conn = ConnectToDB.Connect();
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Bug> GetAll()
        {
            throw new NotImplementedException();
        }

        public Bug GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Bug t)
            //
        {
            int id=0;
           
                conn.Open();
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "insert into ASE.bug(bug_id, program_id, class_name, method_name, line_no, added_date)" +
                    "values(null, :project, :class, :method, :line, current_timestamp)";
                command.Parameters.Add(":project", t.program);
                command.Parameters.Add(":class", t.class_name);
                command.Parameters.Add(":method", t.method_name);
                command.Parameters.Add(":line", t.line_number);

                int done = command.ExecuteNonQuery();
                if (done != 0)
                {
                    OracleCommand command1 = conn.CreateCommand();
                    command1.CommandText = "select ASE.seq_bug.currval from dual";
                    OracleDataReader dr = command1.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            id = dr.GetInt32(0);

                        }
                    }
                }
            
            
            return id;

        }

        public OracleDataAdapter GetBugs()
        {
            OracleConnection conn = ConnectToDB.Connect();
            conn.Open();
            OracleDataAdapter data = new OracleDataAdapter("select b.bug_id, p.program_name, b.class_name, b.method_name from ASE.bug b, ASE.program p where p.program_id=b.bug_id", conn);
            return data;
        }
            public int Update(Bug t)
        {
            throw new NotImplementedException();
        }
    }
}
