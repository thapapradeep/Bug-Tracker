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
            conn.Open();
            OracleCommand command = conn.CreateCommand();
            command.CommandText = "insert into ASE.bug(bug_id, project_name, class_name, method_name, line_no, code_author, added_date)" +
                "values(null, :project, :class, :method, :line, :author, null)";
            command.Parameters.Add(":project", t.project_name);
            command.Parameters.Add(":class", t.class_name);
            command.Parameters.Add(":method", t.method_name);
            command.Parameters.Add(":line", t.line_number);
            command.Parameters.Add(":author", t.code_author);
            //OracleDataReader dr = new OracleDataReader(command);
            return 1;

        }

        public int Update(Bug t)
        {
            throw new NotImplementedException();
        }
    }
}
