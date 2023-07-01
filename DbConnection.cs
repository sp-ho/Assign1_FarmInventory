using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FarmInventory
{
    internal static class DbConnection
    {
        ///* Database connection string */
        //public static string getConnectionString()
        //{
        //    string host = "Host=localhost;";
        //    string port = "Port=5432;";
        //    string dbName = "Database=vanierAECWinter2023;";
        //    string username = "Username=postgres;";
        //    string password = "Password=CharlineUutm@59394;";

        //    string connectionString = string.Format("{0}{1}{2}{3}{4}", host, port, dbName, username, password);
        //    return connectionString;
        //}

        ///* Connect to the database */
        //public static NpgsqlConnection con; // connection adapter
        //public static NpgsqlCommand cmd; // sql command adapter
        //public static void dbConnection()
        //{
        //    // Try-catch statement for error handling while connection to database
        //    try
        //    {
        //        // Create connection
        //        con = new NpgsqlConnection(getConnectionString()); // pass in the connection string
        //        MessageBox.Show("Database Connection Successful.");
        //    }
        //    catch (NpgsqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private static readonly Lazy<NpgsqlConnection> lazyConnection = new Lazy<NpgsqlConnection>(() =>
        {
            NpgsqlConnection connection = new NpgsqlConnection(getConnectionString());
            connection.Open();
            return connection;
        });

        private static string getConnectionString()
        {
            string host = "Host=localhost;";
            string port = "Port=5432;";
            string dbName = "Database=vanierAECWinter2023;";
            string username = "Username=postgres;";
            string password = "Password=CharlineUutm@59394;";

            string connectionString = string.Format("{0}{1}{2}{3}{4}", host, port, dbName, username, password);
            return connectionString;
        }

        public static NpgsqlConnection Connection => lazyConnection.Value;

        public static NpgsqlCommand CreateCommand()
        {
            return Connection.CreateCommand();
        }
    }
}
