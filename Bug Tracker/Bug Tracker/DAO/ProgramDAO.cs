using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bug_Tracker.Forms.Model;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using Bug_Tracker.Forms.DB;
using System.Data;


namespace Bug_Tracker.Forms.DAO
{
   public  class ProgramDAO : GenericDAO<Programs>
    {
        OracleConnection conn = ConnectToDB.Connect();
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Programs> GetAll()
        {
            throw new NotImplementedException();
        }

        public Programs GetById(int id)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Inserts data into program table and returns the integer
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Insert(Programs t)
        {
            int done = 0;
            try
            {
                conn.Open();
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "insert into ASE.program(program_id, program_name, language)" +
                    "values(null, :program_name, :language)";
                command.Parameters.Add(":program_name", t.program_name);
                command.Parameters.Add(":language", t.language);
               done = command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {

            }            
            return done;
              
           
            
        }

        public int Update(Programs t)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Inserts data into user assign table 
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int AssignUsers(ProgramAuthors t)
        {
            Console.WriteLine(t.program_id+" "+t.user_id);
            int done = 0;
            try { 
            conn.Open();
            OracleCommand command = conn.CreateCommand();
            command.CommandText = "insert into ASE.program_authors(id,program_id, user_id)" +
                "values(null,:program_id, :user_id)";
            command.Parameters.Add(":program_id", t.program_id);
            command.Parameters.Add(":user_id", t.user_id);
            done = command.ExecuteNonQuery();

            
        }
            catch(Exception ex)
            {

            }
            return done;

        }


        /// <summary>
        /// Fetches the  program record in descending order and returns OracleDataAdapter
        /// </summary>
        /// <returns></returns>
        public OracleDataAdapter GetPrograms()
        {
            OracleConnection conn = ConnectToDB.Connect();
            conn.Open();
            OracleDataAdapter data = new OracleDataAdapter("select * from ASE.program order by program_id desc", conn);
            return data;
        }
    }
}
