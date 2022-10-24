using System;
using System.Collections.Generic;
using System.Data.SQLite;

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
            catch (Exception e)
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
            }
            catch (Exception e)
            {
                Our.log.LogAdd("Błąd tworzenia lub aktualizacji tabel konfiguracji: " + e.Message);
            }
        }

        public void AddGrupa(string nazwaGrupy)
        {
            //int result = 0;
            try
            {
                SQLiteCommand sqlCmd = connection.CreateCommand();

                sqlCmd.CommandText = "insert into grupy (nazwa) values (@nazwa)";
                sqlCmd.CommandType = System.Data.CommandType.Text;
                sqlCmd.Parameters.Add(new SQLiteParameter("@nazwa", nazwaGrupy));
                sqlCmd.Prepare();
                sqlCmd.ExecuteNonQuery();

            }
            catch (SQLiteException e)
            {
                Our.log.LogAdd("Błąd dodawania nowej grupy: " + e.Message);
            }
        }

        public void UpadteGrupy(int id_grupy, string nazwaGrupy)
        {
            try
            {
                SQLiteCommand cmd = connection.CreateCommand();

                cmd.CommandText = "update grupy set nazwa = @nazwa where id_grupy = @id_grupy";
                cmd.Parameters.Add(new SQLiteParameter("@nazwa", nazwaGrupy));
                cmd.Parameters.Add(new SQLiteParameter("@id_grupy", id_grupy));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                Our.log.LogAdd("Błąd aktualizacji grupy, id_grupy=" + id_grupy + " nazwa=" + nazwaGrupy + " : " + e.Message);
            }
        }

        public void DeleteGrupy(int id_grupy)
        {
            try
            {
                SQLiteCommand cmd = connection.CreateCommand();

                cmd.CommandText = "delete from grupy where id_grupy = @id_grupy";
                cmd.Parameters.Add(new SQLiteParameter("@id_grupy", id_grupy));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                Our.log.LogAdd("Błąd podczas usuwania grupy, id_grupy = " + id_grupy + " : " + e.Message);

            }
        }

        public Dictionary<int, string> getListaGrup()
        {
            Dictionary<int, string> listaGrup = new Dictionary<int, string>();

            SQLiteCommand cmd = new SQLiteCommand("select nazwa, id_grupy from grupy order by upper(nazwa)", connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string grupa = reader.GetString(0);
                int id_grupa = reader.GetInt32(1);
                listaGrup.Add(id_grupa, grupa);
            }

            return listaGrup;
        }

        public void AddHost(int id_grupy, )
    }
}
