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
  public  class BugDetailsDAO : GenericDAO<BugDetails>
    {

        OracleConnection conn = ConnectToDB.Connect();
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<BugDetails> GetAll()
        {
            throw new NotImplementedException();
        }

        public BugDetails GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(BugDetails t)
        {
            conn.Open();
            OracleCommand command = conn.CreateCommand();
            command.CommandText = "insert into ASE.bug_details(bug_id, symptom, cause, image, image_name, source_link, code_block)" +
            "values(:bug_id, :symptom, :cause, :image, :image_name, :source_link, :code_block)";
            command.Parameters.Add(":bug_id", t.bug_id);
            command.Parameters.Add(":symptom", t.symptom);
            command.Parameters.Add(":cause", t.cause);
            command.Parameters.Add(":image", (object)t.image);
            command.Parameters.Add(":image_name", t.image_name);
            command.Parameters.Add(":source_link", t.source_link);
            command.Parameters.Add(":code_block", t.code_block);

            int done = command.ExecuteNonQuery();
            return done;
        }

        public int Update(BugDetails t)
        {
            throw new NotImplementedException();
        }
    }
}
