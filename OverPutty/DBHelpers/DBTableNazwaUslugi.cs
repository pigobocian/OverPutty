using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverPutty.DBHelpers
{
    internal class DBTableNazwaUslugi : IDBTable
    {
        SQLiteCommand cmd;

        public DBTableNazwaUslugi(SQLiteConnection connection)
        {
            this.cmd = connection.CreateCommand();  
        }

        public bool createTable()
        {
            bool result = false;
            try
            {
                // np. SSH, TELNET itd..
                cmd.CommandText = "CREATE TABLE IF NOT EXISTS nazwauslugi ("
                    + "id_nazwauslugi INTEGER PRIMARY KEY AUTOINCREMENT,"
                    + "nazwa TEXT,"
                    + "opis TEXT"
                    + ")";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE INDEX IF NOT EXISTS nazwauslugi_id ON nazwauslugi(id_nazwauslugi)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE INDEX IF NOT EXISTS nazwauslugi_nazwa ON nazwauslugi(nazwa COLLATE NOCASE)";
                cmd.ExecuteNonQuery();
                result = true;
            } catch (Exception e)
            {
                result = false;
            }
            return result;
        }

        public bool insert(params object[] dane)
        {
            bool result = false;
            try
            {
                cmd.CommandText = "insert into nazwauslugi(nazwa, opis) values(@nazwa,@opis)";
                cmd.Parameters.Add(new SQLiteParameter("@nazwa", dane[0]));
                cmd.Parameters.Add(new SQLiteParameter("@opis", dane[1]));
                cmd.ExecuteNonQuery();
                result = true;
            } catch (Exception e)
            {
                result = false;
            }
            return result;
        }

        public bool update(int id, params object[] dane) 
        {
            bool result = false;
            try
            {
                cmd.CommandText = "update nazwauslugi set nazwa = :@nazwa, "
                    + " opis = @opis "
                    + " where id_nazwauslugi = @id_nazwauslugi";
                cmd.Parameters.Add(new SQLiteParameter("@nazwa", dane[0]));
                cmd.Parameters.Add(new SQLiteParameter("@opis", dane[1]));
                cmd.Parameters.Add(new SQLiteParameter("@id_nazwauslugi", dane[2]));
                cmd.ExecuteNonQuery();
                result = true;
            } catch( Exception e)
            {
                result = false;
            }
            return result;
        }

        public bool delete(int id)
        {
            bool result = false;
            try
            {
                cmd.CommandText = "delete from nazwauslugi where id_nazwaulugi = @id_nazwauslugi";
                cmd.Parameters.Add(new SQLiteParameter("@id_nazwauslugi", id));
                cmd.ExecuteNonQuery();
                result = true;
            } catch( Exception e)
            {
                result = false;
            }
            return result;
        }

    }
}
