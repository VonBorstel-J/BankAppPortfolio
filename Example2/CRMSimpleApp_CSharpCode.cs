
using System;
using System.Data.SqlClient;

namespace CRMSimpleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Connection String (Replace with your own connection string)
            string connectionString = "Data Source=Your_Server;Initial Catalog=Your_Database;User ID=Your_User;Password=Your_Password";

            // Create SQL Connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the Connection
                connection.Open();

                // SQL Query to Fetch Data from Customers Table
                string sqlQuery = "SELECT * FROM Customers";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Execute SQL Command and Read Data
                    SqlDataReader reader = command.ExecuteReader();

                    Console.WriteLine("Customer Details:");
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["CustomerID"]}, Name: {reader["FirstName"]} {reader["LastName"]}, Email: {reader["Email"]}");
                    }

                    // Close Reader
                    reader.Close();
                }

                // Close the Connection
                connection.Close();
            }
        }
    }
}
