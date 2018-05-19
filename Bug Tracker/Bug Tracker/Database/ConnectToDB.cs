using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Bug_Tracker.Forms.DB
{
    /// <summary>
    /// Class To connect With Database
    /// </summary>
   public class ConnectToDB
    {
        /// <summary>
        /// Static method that returns OracleConnection
        /// </summary>
        /// <returns></returns>
        public static OracleConnection Connect()
        {
           

            string oradb = " Data Source= DESKTOP-O4LMVGT:1521/XE; User ID = SYSTEM;Password=destination2210 ";
            OracleConnection con = new OracleConnection(oradb);
            
            
                Console.WriteLine(con);
            
            return con;
        }

    }
}
