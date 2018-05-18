using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bug_Tracker.Forms.Model;
using Bug_Tracker.Forms.DB;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;

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

        public DataTable GetAllBugs(int id)
        {
            conn.Open();
            DataTable data = null;
            //try
            //{

            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText="select b.bug_id, p.program_name, b.class_name, b.method_name,b.line_no, b.added_date," +
                    " d.symptom, d.cause, d.image,d.image_name, d.source_link, d.code_block " +
                    "from ASE.bug b, ASE.bug_details d, ASE.program p where b.bug_id = d.bug_id and p.program_id = b.program_id and b.bug_id =:id ";

                cmd.Parameters.Add(":id", id);
                 data = new DataTable();
                data.Load(cmd.ExecuteReader());
            //}
           // catch(Exception ex)
            //{

            //}

            return data;
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

            conn.Close();
            return id;

        }

        public OracleDataAdapter GetBugs()
        {
            OracleConnection conn = ConnectToDB.Connect();
            conn.Open();

            OracleDataAdapter data = new OracleDataAdapter("select b.bug_id, p.program_name, b.class_name, b.method_name from ASE.bug b, ASE.program p where p.program_id=b.program_id", conn);
            conn.Close();
            return data;
            
        }
            public int Update(Bug t)
        {
            throw new NotImplementedException();
        }
        public DataTable GetBugs( int id)
        {
            OracleConnection conn = ConnectToDB.Connect();
            conn.Open();
            OracleCommand command = conn.CreateCommand();
            command.CommandText = "select b.id, b.bug_id, u.fname, b.attemped_date, b.status from ASE.bug_history b, ASE.user_table u where u.user_id=b.user_id and bug_id=:id";
            command.Parameters.Add(":id", id);

            DataTable dr = new DataTable();
            dr.Load(command.ExecuteReader());
  
            
            conn.Close();
            return dr;

        }

        
    }
}
