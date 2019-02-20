using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBconnect
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=CL-JanithU\SQLEXPRESS;Initial Catalog=DBConnect;Integrated Security=true;");
            conn.Open();
            SqlDataAdapter sqldata = new SqlDataAdapter("select * from Connect", conn);
            DataTable dtbl = new DataTable();
            sqldata.Fill(dtbl);
            foreach (DataRow row in dtbl.Rows)
            {
                Console.WriteLine(row["Name"]);
            }
            Console.ReadKey();
        }
    }
}
