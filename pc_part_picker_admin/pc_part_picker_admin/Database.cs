using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace pc_part_picker_admin
{
    class Database
    {

        //As I might be using this software from different computers, I'll get the current pc's name every time.
        private readonly string machineName = Environment.MachineName;

        SqlConnection sqlConn;
        SqlDataAdapter sqlAdapter;
        SqlDataReader sqlReader;
        DataTable dTable;
        

        public Database()
        {
            string connectionString = "Data Source="+machineName+";Initial Catalog=Pc_Part_Picker;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True";
            try
            {
                sqlConn = new SqlConnection(connectionString);
                sqlConn.Open();
                Console.WriteLine("Connection opened at " + machineName);
                sqlConn.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
           

        }

       

       




    }
}
