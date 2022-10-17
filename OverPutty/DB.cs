using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverPutty
{
    class DBInterface
    {
        SQLiteConnection connection;

        public DBInterface()
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
                Our.log.LogAdd("Błąd inicjacji interfejsu bazy SQLite: " + e.Message);
            }
        }

        void InitTables()
        {
            try
            {
                SQLiteCommand sqlCmd = connection.CreateCommand();

                sqlCmd.CommandText = "PRAGMA foreign_keys = ON";
                sqlCmd.ExecuteNonQuery();

                sqlCmd.CommandText = "CREATE TABLE IF NOT EXISTS grupy ( "
                    + "id_grupy INTEGER PRIMARY KEY AUTOINCREMENT,"
                    + "nazwa text"
                    + ")";
                sqlCmd.ExecuteNonQuery();

                sqlCmd.CommandText = "CREATE TABLE IF NOT EXISTS host ("
                    + "id_host INTEGER PRIMARY KEY AUTOINCREMENT,"
                    + "id_grupy INTEGER,"
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
                    + "FOREIGN KEY(id_grupy) REFERENCES grupy(id_grupy)"
                    + ")";
                sqlCmd.ExecuteNonQuery();
            }catch(Exception e)
            {
                Our.log.LogAdd("Błąd tworzenia lub aktualizacji tabel konfiguracji: " + e.Message);
            }
        }

        public int AddGrupa(string nazwaGrupy)
        {
            int result = 0;
            try
            {
                SQLiteCommand sqlCmd = connection.CreateCommand();

                sqlCmd.CommandText = "insert into grupy (nazwa) values (@nazwa)";
                sqlCmd.CommandType = System.Data.CommandType.Text;
                sqlCmd.Parameters.Add(new SQLiteParameter("@nazwa", nazwaGrupy));
                sqlCmd.Prepare();
                sqlCmd.ExecuteNonQuery();

                connection.Open();
                SQLiteCommand cmdSelect = new SQLiteCommand("select max(id_grupy) from grupy", connection);
                SQLiteDataReader reader = sqlCmd.ExecuteReader();

                if (reader.Read())
                {
                    result = reader.GetInt32(0);
                }

            } catch (Exception e)
            {
                Our.log.LogAdd("Błąd dodawania nowej grupy: " + e.Message);
            }
            return result;
        }
    }
}
