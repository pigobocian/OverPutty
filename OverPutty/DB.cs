using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace OverPutty
{
    class DBInterface
    {
        public const string TABLE_GROUP = "hostGroup";
        public const string GROUP_ID_GROUP = "id_hostGroup";
        public const string GROUP_NAME = "name";

        public const string TABLE_HOST = "host";
        public const string HOST_ID_HOST = "id_host";
        public const string HOST_ID_GROUP = GROUP_ID_GROUP;
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
        public const string CONFIG_PARAMNAME = "paramName";
        public const string CONFIG_PARAMVALUE = "paramValue";

        public const string SQL_TEXT = " text";
        public const string SQL_INTEGER = " INTEGER";

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
            connection = new SQLiteConnection("Data Source=config.sqlite; Version = 3; New = True; Compress = True; ");
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                Our.log.LogAdd(GetMessge(ERR_MSG_SQL_INIT_ERROR, Our.selectedLanguage) + e.Message);
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
                Our.log.LogAdd(GetMessge(ERR_MSG_SQL_CREATE_OPEN_TABLE_ERROR, Our.selectedLanguage) + e.Message);
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
                Our.log.LogAdd(GetMessge(ERR_MSG_SQL_GROUP_ADD_ERROR, Our.selectedLanguage) + e.Message);
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
                Our.log.LogAdd(GetMessge(ERR_MSG_SQL_GROUP_UPDATE_ERROR, Our.selectedLanguage) + id_grup + " nazwa=" + groupName + " : " + e.Message);
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
                Our.log.LogAdd(GetMessge(ERR_MSG_SQL_GROUP_DELETE_ERROR, Our.selectedLanguage) + id_group + " : " + e.Message);

            }
        }

        public Dictionary<int, string> getGroupList()
        {
            Dictionary<int, string> groupList = new Dictionary<int, string>();

            try
            {
                string sqlCmd = "select " + GROUP_NAME + ", " + GROUP_ID_GROUP + " from " + TABLE_GROUP + " order by upper(" + GROUP_NAME + ")";
                SQLiteCommand cmd = new SQLiteCommand(sqlCmd, connection);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string groupName = reader.GetString(0);
                    int id_group = reader.GetInt32(1);
                    groupList.Add(id_group, groupName);
                }
            }
            catch (SQLiteException e)
            {
                Our.log.LogAdd("Błąd pobierania tabeli grup: " + e.Message);
            }

            return groupList;
        }

        public void AddHost(int hostId_group, string hostName, string hostPort, string hostUser, string hostPass, string hostCompress, string hostSSHVer,
            string hostProtocol, string hostTCPVer, string hostPrivKey, string hostAddCmd1, string hostAddCmd2, string hostAddCmd3, string hostAddCmd4
            , string hostAddCmd5, string hostAddCmd6, string hostAddCmd7, string hostAddCmd8, string hostAddCmd9)
        {
            try
            {
                SQLiteCommand cmd = connection.CreateCommand();

                cmd.CommandText = "insert into " + TABLE_HOST + "(" +
                HOST_ID_GROUP + "," + HOST_NAME + "," + HOST_PORT + "," + HOST_HOST + "," + HOST_USER + "," +
                HOST_PASS + "," + HOST_COMPRESS + "," + HOST_SSH_VER + "," + HOST_PROTOCOL + "," + HOST_TCP_VER + "," +
                HOST_PRIVKEY + "," + HOST_ADDCMD1 + "," + HOST_ADDCMD2 + "," + HOST_ADDCMD3 + "," + HOST_ADDCMD4 + "," +
                HOST_ADDCMD5 + "," + HOST_ADDCMD6 + "," + HOST_ADDCMD7 + "," + HOST_ADDCMD8 + "," + HOST_ADDCMD9 +
                ") values (" +
                "@" + HOST_ID_GROUP + "," + "@" + HOST_NAME + "," + "@" + HOST_PORT + "," + "@" + HOST_HOST + "," +
                "@" + HOST_USER + "," + "@" + HOST_PASS + "," + "@" + HOST_COMPRESS + "," + "@" + HOST_SSH_VER + "," +
                "@" + HOST_PROTOCOL + "," + "@" + HOST_TCP_VER + "," + "@" + HOST_PRIVKEY + "," + "@" + HOST_ADDCMD1 + "," +
                "@" + HOST_ADDCMD2 + "," + "@" + HOST_ADDCMD3 + "," + "@" + HOST_ADDCMD4 + "," + "@" + HOST_ADDCMD5 + "," +
                "@" + HOST_ADDCMD6 + "," + "@" + HOST_ADDCMD7 + "," + "@" + HOST_ADDCMD8 + "," + "@" + HOST_ADDCMD9 + ")";

                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_ID_GROUP, hostId_group));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_NAME, hostName));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_PORT, hostPort));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_HOST, hostName));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_USER, hostUser));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_PASS, hostPass));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_COMPRESS, hostCompress));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_SSH_VER, hostSSHVer));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_PROTOCOL, hostProtocol));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_TCP_VER, hostTCPVer));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_PRIVKEY, hostPrivKey));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_ADDCMD1, hostAddCmd1));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_ADDCMD2, hostAddCmd2));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_ADDCMD3, hostAddCmd3));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_ADDCMD4, hostAddCmd4));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_ADDCMD5, hostAddCmd5));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_ADDCMD6, hostAddCmd6));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_ADDCMD7, hostAddCmd7));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_ADDCMD8, hostAddCmd8));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_ADDCMD9, hostAddCmd9));

                cmd.Prepare();
                cmd.ExecuteNonQuery();

            }
            catch (SQLiteException e)
            {
                Our.log.LogAdd(GetMessge(ERR_MSG_SQL_HOST_ADD_ERROR, Our.selectedLanguage) + hostName + " : " + e.Message);
            }
        }

        public void UpdateHost(int id_host, int hostId_group, string hostName, string hostPort, string hostUser, string hostPass, string hostCompress, string hostSSHVer,
            string hostProtocol, string hostTCPVer, string hostPrivKey, string hostAddCmd1, string hostAddCmd2, string hostAddCmd3, string hostAddCmd4
            , string hostAddCmd5, string hostAddCmd6, string hostAddCmd7, string hostAddCmd8, string hostAddCmd9)
        {
            try
            {
                SQLiteCommand cmd = connection.CreateCommand();

                cmd.CommandText = "update " + TABLE_HOST + " set " +
                HOST_ID_GROUP + "=" + "@" + HOST_ID_GROUP + "," +
                HOST_NAME + "=" + "@" + HOST_NAME + "," +
                HOST_PORT + "=" + "@" + HOST_PORT + "," +
                HOST_HOST + "=" + "@" + HOST_HOST + "," +
                HOST_USER + "=" + "@" + HOST_USER + "," +
                HOST_PASS + "=" + "@" + HOST_PASS + "," +
                HOST_COMPRESS + "=" + "@" + HOST_COMPRESS + "," +
                HOST_SSH_VER + "=" + "@" + HOST_SSH_VER + "," +
                HOST_PROTOCOL + "=" + "@" + HOST_PROTOCOL + "," +
                HOST_TCP_VER + "=" + "@" + HOST_TCP_VER + "," +
                HOST_PRIVKEY + "=" + "@" + HOST_PRIVKEY + "," +
                HOST_ADDCMD1 + "=" + "@" + HOST_ADDCMD1 + "," +
                HOST_ADDCMD2 + "=" + "@" + HOST_ADDCMD2 + "," +
                HOST_ADDCMD3 + "=" + "@" + HOST_ADDCMD3 + "," +
                HOST_ADDCMD4 + "=" + "@" + HOST_ADDCMD4 + "," +
                HOST_ADDCMD5 + "=" + "@" + HOST_ADDCMD5 + "," +
                HOST_ADDCMD6 + "=" + "@" + HOST_ADDCMD6 + "," +
                HOST_ADDCMD7 + "=" + "@" + HOST_ADDCMD7 + "," +
                HOST_ADDCMD8 + "=" + "@" + HOST_ADDCMD8 + "," +
                HOST_ADDCMD9 + "=" + "@" + HOST_ADDCMD9 +
                " where id_host = " + id_host;

                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_ID_HOST, id_host));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_ID_GROUP, hostId_group));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_NAME, hostName));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_PORT, hostPort));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_HOST, hostName));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_USER, hostUser));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_PASS, hostPass));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_COMPRESS, hostCompress));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_SSH_VER, hostSSHVer));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_PROTOCOL, hostProtocol));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_TCP_VER, hostTCPVer));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_PRIVKEY, hostPrivKey));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_ADDCMD1, hostAddCmd1));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_ADDCMD2, hostAddCmd2));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_ADDCMD3, hostAddCmd3));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_ADDCMD4, hostAddCmd4));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_ADDCMD5, hostAddCmd5));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_ADDCMD6, hostAddCmd6));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_ADDCMD7, hostAddCmd7));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_ADDCMD8, hostAddCmd8));
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_ADDCMD9, hostAddCmd9));

                cmd.Prepare();
                cmd.ExecuteNonQuery();

            }
            catch (SQLiteException e)
            {
                Our.log.LogAdd(GetMessge(ERR_MSG_SQL_HOST_UPDATE_ERROR, Our.selectedLanguage) + hostName + " : " + e.Message);
            }
        }

        public void DeleteHost(int id_host)
        {
            try
            {
                SQLiteCommand cmd = connection.CreateCommand();

                cmd.CommandText = "delete from " + TABLE_HOST + " where " + HOST_ID_HOST + "= @" + HOST_ID_HOST;
                cmd.Parameters.Add(new SQLiteParameter("@" + HOST_ID_HOST, id_host));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                Our.log.LogAdd(GetMessge(ERR_MSG_SQL_HOST_DELETE_ERROR, Our.selectedLanguage) + id_host + " : " + e.Message);
            }

        }


        public string GetMessge(int messageNo, int languageNo)
        {
            string msgBuf = "";
            switch (languageNo)
            {
                case Our.languagePolish:
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
                case Our.languageEnglish:
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
