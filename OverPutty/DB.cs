using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace OverPutty
{
    class DBInterface
    {
        public const string TABLE_GROUP = "group";
        public const string GROUP_ID_GROUP = "id_group";
        public const string GROUP_NAME = "name";

        public const string TABLE_HOST = "host";
        public const string HOST_ID_HOST = "id_host";
        public const string HOST_ID_GROUP = "id_grup";
        public const string HOST_NAME = "name";
        public const string HOST_PORT = "port";
        public const string HOST_HOST = "host";
        public const string HOST_USER = "user";
        public const string HOST_PASS = "pass";
        public const string HOST_COMPRESS = "compress";        // Compression 1 - on, 0 - off
        public const string HOST_SSH_VER = "ssh_ver";          // Version of SSH protocol 1, 2 lub 0-czyli nic
        public const string HOST_PROTOCOL = "protocol";        // Protocol type 1-SSH, 2-telnet, 3-rlogin, 4-raw, 5-serial
        public const string HOST_TCP_VER = "tcp_ver";          // TCP protocol wersion 4, 6 lub 0-czyli nic
        public const string HOST_PRIVKEY = "privkey";          // SSH keyfile, not path, this field contains content of keyfile
        public const string HOST_ADDCMD1 = "addcmd1";          // Additional command, from 1 to 9
        public const string HOST_ADDCMD2 = "addcmd2";
        public const string HOST_ADDCMD3 = "addcmd3";
        public const string HOST_ADDCMD4 = "addcmd4";
        public const string HOST_ADDCMD5 = "addcmd5";
        public const string HOST_ADDCMD6 = "addcmd6";
        public const string HOST_ADDCMD7 = "addcmd7";
        public const string HOST_ADDCMD8 = "addcmd8";
        public const string HOST_ADDCMD9 = "addcmd9";

        public const string TABLE_CONFIG = "config";
        public const string CONFIG_PARAMNAME = "paramname";
        public const string CONFIG_PARAMVALUE = "paramvalue";

        public const string SQL_TEXT = " text";
        public const string SQL_INTEGER = " INTEGER";

        public const int errMsgSQLInitError = 1;
        public const int errMsgSQLCreateOpenTablesError = 2;


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
                Our.log.LogAdd(GetMessge(errMsgSQLInitError, Our.selectedLanguage) + e.Message);
            }
        }

        void InitTables()
        {
            try
            {
                SQLiteCommand sqlCmd = connection.CreateCommand();

                sqlCmd.CommandText = "PRAGMA foreign_keys = ON";
                sqlCmd.ExecuteNonQuery();

                sqlCmd.CommandText = "CREATE TABLE IF NOT EXISTS " + TABLE_GROUP + " ( "
                    + GROUP_ID_GROUP + SQL_INTEGER + " PRIMARY KEY AUTOINCREMENT,"
                    + GROUP_NAME + SQL_TEXT
                    + ")";
                sqlCmd.ExecuteNonQuery();

                sqlCmd.CommandText = "CREATE TABLE IF NOT EXISTS " + TABLE_HOST + " ("
                    + HOST_ID_HOST + SQL_INTEGER + " PRIMARY KEY AUTOINCREMENT,"
                    + HOST_ID_GROUP + SQL_TEXT + ","
                    + HOST_NAME + SQL_TEXT + ","
                    + HOST_PORT + SQL_INTEGER + ","
                    + HOST_HOST + SQL_INTEGER + ","
                    + HOST_USER + SQL_TEXT + ","
                    + HOST_PASS + SQL_TEXT + ","
                    + HOST_COMPRESS + SQL_INTEGER + ","
                    + HOST_SSH_VER + SQL_INTEGER + ","
                    + HOST_PROTOCOL + SQL_INTEGER + ","
                    + HOST_TCP_VER + SQL_INTEGER + ","
                    + HOST_PRIVKEY + SQL_TEXT + ","
                    + HOST_ADDCMD1 + SQL_TEXT + ","
                    + HOST_ADDCMD2 + SQL_TEXT + ","
                    + HOST_ADDCMD3 + SQL_TEXT + ","
                    + HOST_ADDCMD4 + SQL_TEXT + ","
                    + HOST_ADDCMD5 + SQL_TEXT + ","
                    + HOST_ADDCMD6 + SQL_TEXT + ","
                    + HOST_ADDCMD7 + SQL_TEXT + ","
                    + HOST_ADDCMD8 + SQL_TEXT + ","
                    + HOST_ADDCMD9 + SQL_TEXT + ","
                    + "FOREIGN KEY(" + HOST_ID_GROUP + ") REFERENCES " + TABLE_GROUP + "(" + GROUP_ID_GROUP + ")"
                    + ")";
                sqlCmd.ExecuteNonQuery();

                sqlCmd.CommandText = "CREATE TABLE IF NOT EXISTS " + TABLE_CONFIG + " ( "
                    + CONFIG_PARAMNAME + SQL_TEXT + ","
                    + CONFIG_PARAMVALUE + SQL_TEXT
                    + ")";
                sqlCmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Our.log.LogAdd(GetMessge(errMsgSQLCreateOpenTablesError, Our.selectedLanguage) + e.Message);
            }
        }

        public void AddGroup(string groupName)
        {
            //int result = 0;
            try
            {
                SQLiteCommand sqlCmd = connection.CreateCommand();

                sqlCmd.CommandText = "insert into " + TABLE_GROUP + " (" + GROUP_NAME + ") values (@groupName)";
                sqlCmd.CommandType = System.Data.CommandType.Text;
                sqlCmd.Parameters.Add(new SQLiteParameter("@groupName", groupName));
                sqlCmd.Prepare();
                sqlCmd.ExecuteNonQuery();

            }
            catch (SQLiteException e)
            {
                Our.log.LogAdd("Błąd dodawania nowej grupy: " + e.Message);
            }
        }

        public void UpdateGroup(int id_grup, string groupName)
        {
            try
            {
                SQLiteCommand cmd = connection.CreateCommand();

                cmd.CommandText = "update " + TABLE_GROUP + " set " + GROUP_NAME + " = @groupName where " + GROUP_ID_GROUP + " = @id_group";
                cmd.Parameters.Add(new SQLiteParameter("@groupName", groupName));
                cmd.Parameters.Add(new SQLiteParameter("@id_group", id_grup));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                Our.log.LogAdd("Błąd aktualizacji grupy, id_grupy=" + id_grup + " nazwa=" + groupName + " : " + e.Message);
            }
        }

        public void DeleteGroup(int id_group)
        {
            try
            {
                SQLiteCommand cmd = connection.CreateCommand();

                cmd.CommandText = "delete from " + TABLE_GROUP + " where " + GROUP_ID_GROUP + " = @id_group";
                cmd.Parameters.Add(new SQLiteParameter("@id_group", id_group));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                Our.log.LogAdd("Błąd podczas usuwania grupy, id_grupy = " + id_group + " : " + e.Message);

            }
        }

        public Dictionary<int, string> getGroupList()
        {
            Dictionary<int, string> groupList = new Dictionary<int, string>();

            SQLiteCommand cmd = new SQLiteCommand("select " + GROUP_NAME + ", " + GROUP_ID_GROUP + " from " + TABLE_GROUP + " order by upper(" + GROUP_NAME + ")", connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string groupName = reader.GetString(0);
                int id_group = reader.GetInt32(1);
                groupList.Add(id_group, groupName);
            }

            return groupList;
        }

        public void AddHost(int id_group, string hostName)
        {

        }

        public string GetMessge(int messageNo, int languageNo)
        {
            string msgBuf = "";
            switch (languageNo)
            {
                case Our.languagePolish:
                    switch (messageNo)
                    {
                        case errMsgSQLInitError: msgBuf = "Błąd inicjacji interfejsu bazy SQLite"; break;
                        case errMsgSQLCreateOpenTablesError: msgBuf = "Błąd tworzenia lub aktualizacji tabel konfiguracji"; break;
                    };
                    break;
                case Our.languageEnglish:
                    switch (messageNo)
                    {
                        case errMsgSQLInitError: msgBuf = "Error SQLite initialisation"; break;
                        case errMsgSQLCreateOpenTablesError: msgBuf = "Error create or open SQLite database file"; break;
                    };
                    break;

            }
            return msgBuf + ": ";

        }
    }
}
