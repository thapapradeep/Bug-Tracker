using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bug_Tracker.Forms.Model;
using Bug_Tracker.Forms.DB;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using Bug_Tracker.Forms.DB;


namespace Bug_Tracker.Forms.DAO
{
     public class UserDAO : GenericDAO<UserTable>
    {
        OracleConnection conn = ConnectToDB.Connect();
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


        /// <summary>
        /// Selexts user according to username and passworf for user login
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
         public OracleDataReader UserLogin(UserTable user)
        {
            OracleDataReader data=null;
            try
            {
               
                conn.Open();
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "select u.user_id, t.type_name from ASE.user_table u, ASE.user_type t where t.type_id = u.type_id and" +
                    " username =:username and password =:password";


                OracleParameter op = new OracleParameter();
                command.Parameters.Add(":username", user.username);
                command.Parameters.Add(":password", user.password);

               data = command.ExecuteReader();
            }
            catch (Exception ex){
            }

            return data;
        }

        /// <summary>
        /// Inserts the user information into user table
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Insert(UserTable t)
        {
            int done = 0;
            try
            {
                conn.Open();
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "Insert into ASE.user_table(user_id, fname, lname, contact, address, username, password, type_id)" +
                    "values(null, :Fname, :Lname, :Contact, :Address, :Username, :Password, :Type_id)";
                command.Parameters.Add(":Fname", t.fname);
                command.Parameters.Add(":Lname", t.lname);
                command.Parameters.Add(":Contact", t.contact);
                command.Parameters.Add(":Address", t.address);
                command.Parameters.Add(":username", t.username);
                command.Parameters.Add(":password", t.password);
                command.Parameters.Add(":type_id", t.type_id);
                done = command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {

            }
            return done;
           
        }

        /// <summary>
        /// Updates the current password and returns int
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>

        public int Update(UserTable t)
        {
            int done = 0;
            try
            {
                conn.Open();

                OracleCommand command = conn.CreateCommand();
                command.CommandText = "update ASE.user_table set password = " + t.password + " where user_id = " + t.user_id + "";
                command.Parameters.Add(":id", t.user_id);
                command.Parameters.Add(":password", t.password);
                done = command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {

            }
            return done;

            
            
        }

        /// <summary>
        /// Gets user information and returns Oracle Data Adapter
        /// </summary>
        /// <returns></returns>
        public OracleDataAdapter GetUsers() 
        {
            
            conn.Open();
            OracleDataAdapter data = new OracleDataAdapter("select u.user_id, u.fname, t.type_name from ASE.user_table u, ASE.user_type t where t.type_id=u.type_id", conn);
           
            return data;
        }
    }
}
