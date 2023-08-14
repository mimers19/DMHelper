using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace DMHelper.Assets
{
    internal static class DB
    {
        private static string connString = "Data Source=C:\\Users\\dell\\OneDrive\\Dokumenty\\GitHub\\DMHelper\\DMHelper\\DataBase\\DMHelperDB.db";
        static SqliteConnection connection;

        public static void Connect()
        {
            connection = new SqliteConnection(connString);
            Console.WriteLine("Success");
        }

        public static void Disconnect()
        {

        }
    }
}
