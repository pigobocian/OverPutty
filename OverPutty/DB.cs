using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverPutty
{
    class DB
    {
        SQLiteConnection connection;

        public DB()
        {
            InitConnection();
            InitTables();
        }

        void InitConnection()
        {
            connection = new SQLiteConnection("Data Source=config.sqlite; Version = 3; New = True; Compress = True; ");
            try
            {
                connection.Open();
            }
            catch(Exception e)
            {

            }
        }

        void InitTables()
        {
            SQLiteCommand sqlCmd = connection.CreateCommand();

            sqlCmd.CommandText = "PRAGMA foreign_keys = ON";
            sqlCmd.ExecuteNonQuery();

            sqlCmd.CommandText = "CREATE TABLE IF NOT EXISTS group ( "
                + "id_group INTEGER PRIMARY KEY AUTOINCREMENT,"
                + "nazwa text"
                + ")";
            sqlCmd.ExecuteNonQuery();

            sqlCmd.CommandText = "CREATE TABLE IF NOT EXISTS host ("
                + "id_host INTEGER PRIMARY KEY AUTOINCREMENT,"
                + "id_group INTEGER,"
                + "nazwa TEXT,"
                + "port INTEGER,"
                + "hosturl TEXT,"
                + "user TEXT,"
                + "password TEXT,"
                + "compression INTEGER," // 1 - on, 0 - off
                + "protocolver INTERER," // 1 lub 2
                + "privkey TEXT,"        // lokalizacja klucza prywatnego
                + "addcmd1 TEXT,"
                + "addcmd2 TEXT,"
                + "addcmd3 TEXT,"
                + "addcmd4 TEXT,"
                + "addcmd5 TEXT,"
                + "FOREIGN KEY(id_group) REFERENCES group(id_group)"
                + ")";
            sqlCmd.ExecuteNonQuery();
        }
    }
}
