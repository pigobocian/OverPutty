using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Runtime.CompilerServices;

namespace OverPutty
{

    class DBInterface
    {

        public const int ERR_MSG_SQL_INIT_ERROR = 1;
        public const int ERR_MSG_SQL_CREATE_OPEN_TABLE_ERROR = 2;

        public const int ERR_MSG_SQL_HOST_ADD_ERROR = 3;
        public const int ERR_MSG_SQL_HOST_UPDATE_ERROR = 4;
        public const int ERR_MSG_SQL_HOST_DELETE_ERROR = 5;

        public const int ERR_MSG_SQL_GROUP_ADD_ERROR = 6;
        public const int ERR_MSG_SQL_GROUP_UPDATE_ERROR = 7;
        public const int ERR_MSG_SQL_GROUP_DELETE_ERROR = 8;




        SQLiteConnection connection;

        public DBInterface()
        {
            InitConnection();
            InitTables();
        }

        void InitConnection()
        {
            connection = new SQLiteConnection("Data Source=config.sqlite; Version = 3; New = True; Compress = False; ");
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                Common.log.LogAdd(GetMessge(ERR_MSG_SQL_INIT_ERROR, Common.selectedLanguage) + e.Message);
            }
        }

        public SQLiteConnection GetConnection()
        {
            return connection;
        }




        void InitTables()
        {
            try
            {
                SQLiteCommand sqlCmd = connection.CreateCommand();

                sqlCmd.CommandText = "PRAGMA foreign_keys = ON";
                sqlCmd.ExecuteNonQuery();


                // główna tabela

                // występowanie parametrów w tabeli głównej

                // słowniki wartości dla cech

                // wartości (pozycje) słowników

                // cechy opisujące wiersz w tabeli głównej
                // np. firma, odział, kolor itp.

                // wartości cech, pole wblob jest przeznaczone na pzrechowywanie
                // zawartosci plików, np. pliku klucza prywtnego SSH
                // i jesli wartość != null to jest dołączona tuz za WARTOSC 
                // poprzedzona polem ROZDZIEL, czyli:
                // WARTOSCROZDZELABLOB
                // pole rozdziel bedzie przyjmować np. wartość spacji, znaku = itd ...
                sqlCmd.CommandText = "CREATE TABLE IF NOT EXISTS wystcecha ( "
                    + "id_wystcecha PRIMARY KEY AUTOINCREMENT,"
                    + "id_main INTEGER,"
                    + "id_cecha INTEGER,"
                    + "wartosc TEXT,"
                    + "rozdziel TEXT,"
                    + "ablob BLOB,"
                    + "opis TEXT,"
                    + "FOREIGN KEY(id_cecha) REFERENCES cecha(id_cecha)"
                    + ")";
                sqlCmd.ExecuteNonQuery();
                sqlCmd.CommandText = "CREATE INDEX IF NOT EXISTS wystcecha_id ON wystcecha(id_wystcecha)";
                sqlCmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Common.log.LogAdd(GetMessge(ERR_MSG_SQL_CREATE_OPEN_TABLE_ERROR, Common.selectedLanguage) + e.Message);
            }
        }




        public string GetMessge(int messageNo, int languageNo)
        {
            string msgBuf = "";
            switch (languageNo)
            {
                case Common.languagePolish:
                    switch (messageNo)
                    {
                        case ERR_MSG_SQL_INIT_ERROR: msgBuf = "Błąd inicjacji interfejsu bazy SQLite"; break;
                        case ERR_MSG_SQL_CREATE_OPEN_TABLE_ERROR: msgBuf = "Błąd tworzenia lub aktualizacji tabel konfiguracji"; break;
                        case ERR_MSG_SQL_HOST_ADD_ERROR: msgBuf = "Błąd podczas dodawania hosta"; break;
                        case ERR_MSG_SQL_HOST_UPDATE_ERROR: msgBuf = "Błąd aktualizacji hosta"; break;
                        case ERR_MSG_SQL_HOST_DELETE_ERROR: msgBuf = "Błąd podczas usówania hosta"; break;
                        case ERR_MSG_SQL_GROUP_ADD_ERROR: msgBuf = "Błąd podczas dodawania grupy"; break;
                        case ERR_MSG_SQL_GROUP_UPDATE_ERROR: msgBuf = "Błąd podczas aktualizacji grupy"; break;
                        case ERR_MSG_SQL_GROUP_DELETE_ERROR: msgBuf = "Błąd odczas kasowania grupy"; break;

                    };
                    break;
                case Common.languageEnglish:
                    switch (messageNo)
                    {
                        case ERR_MSG_SQL_INIT_ERROR: msgBuf = "Error SQLite initialisation"; break;
                        case ERR_MSG_SQL_CREATE_OPEN_TABLE_ERROR: msgBuf = "Error create or open SQLite database file"; break;
                        case ERR_MSG_SQL_HOST_ADD_ERROR: msgBuf = "Host add error"; break;
                        case ERR_MSG_SQL_HOST_UPDATE_ERROR: msgBuf = "Host update error"; break;
                        case ERR_MSG_SQL_HOST_DELETE_ERROR: msgBuf = "Host delete error"; break;
                        case ERR_MSG_SQL_GROUP_ADD_ERROR: msgBuf = "Group add error"; break;
                        case ERR_MSG_SQL_GROUP_UPDATE_ERROR: msgBuf = "Group update error"; break;
                        case ERR_MSG_SQL_GROUP_DELETE_ERROR: msgBuf = "Group delete error"; break;

                    };
                    break;

            }
            return msgBuf + ": ";

        }
    }
}
