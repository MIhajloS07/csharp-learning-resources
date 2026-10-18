using System.Data;
using System.Data.SqlClient;
using System;

namespace DataTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=NorthWind;Integrated Security=True;Encrypt=False";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Suppliers", conn);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                //foreach (DataRow rows in dt.Rows)
                //    Console.WriteLine(rows["CompanyName"]);
                // DATAROW
                foreach (DataRow row in dt.Rows)
                    Console.WriteLine($"{row["CompanyName"]}: phone {row["Phone"]}");
                Console.WriteLine("=====================================");
                //DATACOLUMN
                foreach (DataColumn col in dt.Columns)
                    Console.WriteLine($"{col.ColumnName} -> ({col.DataType})");
                Console.WriteLine("=====================================");
                //DATAVIEW 
                DataView view = new DataView(dt);
                view.RowFilter = "Country = 'Germany'";
                view.Sort = "CompanyName ASC";
                foreach (DataRowView drv in view)
                    Console.WriteLine($"{drv["CompanyName"]}");
            }
        }
    }
}
