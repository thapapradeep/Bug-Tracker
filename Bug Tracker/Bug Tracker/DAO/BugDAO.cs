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
     public class BugDAO : GenericDAO<Bug>

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
        /// <summary>
        /// Fetches all bugs and returns dataset
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns
        public DataTable GetAllBugs(int id)
        {
            conn.Open();
            DataTable data = null;
            try
            {

            OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select b.bug_id, p.program_name, b.class_name, b.method_name,b.line_no, b.added_date ,d.symptom, d.cause, d.image,d.image_name, d.source_link, d.code_block , u.fname from ASE.bug b, ASE.bug_details d, ASE.program p, ASE.user_table u  where b.bug_id = d.bug_id and p.program_id = b.program_id and u.user_id = b.found_by  and b.bug_id = :id";

                cmd.Parameters.Add(":id", id);
                 data = new DataTable();
                data.Load(cmd.ExecuteReader());
            }
            catch(Exception ex)
            {

            }

            return data;
        }

        /// <summary>
        /// Fetches all bugs that a programmer is assigned to and returns dataset
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable GetProgrammerBugs(int id)
        {
            conn.Open();
            DataTable data = null;
            try
            {

            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select b.bug_id, p.program_name, b.class_name, b.method_name from " +
                "ASE.bug b, ASE.program p, ASE.user_assign h, ASE.user_table u  " +
                " where p.program_id=b.program_id and b.bug_id=h.bug_id and h.bug_id=b.bug_id and u.user_id=h.user_id and h.user_id=:id";


            cmd.Parameters.Add(":id", id);
            data = new DataTable();
            data.Load(cmd.ExecuteReader());
            }
             catch(Exception ex)
            {

            }

            return data;
        }
        public DataTable GetTesterBugs(int id)
        {
            conn.Open();
            DataTable data = null;
            try
            {

            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select b.bug_id, p.program_name, b.class_name, b.method_name from ASE.bug b, ASE.program p  where p.program_id=b.program_id and b.found_by=:id";


            cmd.Parameters.Add(":id", id);
            data = new DataTable();
            data.Load(cmd.ExecuteReader());
            }
             catch(Exception ex)
            {

            }

            return data;
        }

        /// <summary>
        /// Code to Insert new Bug. Takes Integer and returns Integer
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Insert(Bug t)
            
        {
            int id=0;
            try
            {



                conn.Open();
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "insert into ASE.bug(bug_id, program_id, class_name, method_name, line_no, added_date, found_by)" +
                    "values(null, :project, :class, :method, :line, current_timestamp, :found_by)";
                command.Parameters.Add(":project", t.program);
                command.Parameters.Add(":class", t.class_name);
                command.Parameters.Add(":method", t.method_name);
                command.Parameters.Add(":line", t.line_number);
                command.Parameters.Add(":found_by", t.found_by);

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
            }
            catch (Exception)
            {

                throw;
            }

            conn.Close();
            return id;

        }
        /// <summary>
        /// Returns Oracle Adapter
        /// </summary>
        /// <returns></returns>
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


        /// <summary>
        /// Fetches All record from bug table and returns the resultset table
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
