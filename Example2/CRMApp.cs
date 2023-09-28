using System;
using System.Data.SqlClient;

// CRMApp to fetch customer details from a database
namespace CRMApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the connection string (I would replace the placeholders with actual values IRL)
            string connectionString = "Data Source=Your_Server;Initial Catalog=Your_Database;User ID=Your_User;Password=Your_Password";

            // Create and manage SQL Connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // SQL Query to fetch customer details
                string sqlQuery = "SELECT * FROM Customers";

                // Create and execute SQL Command
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Execute the query and read the data
                    SqlDataReader reader = command.ExecuteReader();

                    // Display customer details
                    Console.WriteLine("Customer Details:");
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["CustomerID"]}, Name: {reader["FirstName"]} {reader["LastName"]}, Email: {reader["Email"]}");
                    }

                    // Close the reader
                    reader.Close();
                }

                // Close the connection
                connection.Close();
            }
        }
    }
}
