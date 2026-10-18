using System;
using System.Data.SqlClient;
using System.Data;

namespace DataSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=NorthWind;Integrated Security=True;Encrypt=False";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                System.Data.DataSet ds = new System.Data.DataSet("SuppliersAndProducts");
                SqlDataAdapter sSuppliers = new SqlDataAdapter("SELECT * FROM Suppliers", conn);
                sSuppliers.Fill(ds, "Suppliers");
                SqlDataAdapter sProducts = new SqlDataAdapter("SELECT * FROM Products", conn);
                sProducts.Fill(ds, "Products");
                DataRelation relation = new DataRelation(
                    "SuppliersProducts",
                    ds.Tables["Suppliers"].Columns["SupplierID"],
                    ds.Tables["Products"].Columns["SupplierID"]
                );
                ds.Relations.Add(relation); 
                foreach(DataRow supplier in ds.Tables["Suppliers"].Rows)
                {
                    Console.WriteLine("Supplier: {0}", supplier["CompanyName"]);
                    foreach (DataRow product in supplier.GetChildRows(relation))
                    {
                        Console.WriteLine("\tProduct: {0}", product["ProductName"]);
                    }
                }
            }
        }
    }
}
