using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SQLSERVERCONNECTIONLIBRARY
{
    public class  SqlServerConnectionManager
    {
        public static SqlConnection OpenConnection(string connString)
        {
            SqlConnection conn = null;
            //STEP1:CONFIGURE CONNECTIONSTRING
            try
            {
                //STEP2:OPENCONNECTION
                //connstring coming from eachproject App.config
                if (connString != null || Convert.ToString(conn.State) == "closed")
                {
                    //Open Connection
                    conn = new SqlConnection(connString);
                    conn.Open();
                }
                return conn;

            }
            catch (SqlException ex)
            {
                Console.WriteLine("oops,sql server error");
                Console.WriteLine(ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("oops,something went wrong "+ex);
                Console.WriteLine(ex.Message);
                return null;
            }
           
        }
    }
}
