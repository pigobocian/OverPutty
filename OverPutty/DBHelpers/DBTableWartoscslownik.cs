using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverPutty.DBHelpers
{
    internal class DBTableWartoscslownik : IDBTable
    {
        private SQLiteCommand cmd;

        public DBTableWartoscslownik(SQLiteCommand cmd)
        {
            this.cmd = cmd; 
        }

        public bool createTable()
        {
            bool result = false;
            try
            {
                cmd.CommandText = "CREATE TABLE IF NOT EXISTS wartoscslownik ( "
                    + "id_wartoscslownik INTEGER PRIMARY KEY AUTOINCREMENT,"
                    + "id_slownik INTEGER,"
                    + "wartosc text,"
                    + "FOREIGN KEY(id_slownik) REFERENCES slownik(id_slownik)"
                    + ")";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE INDEX IF NOT EXISTS wartoscslownik_id ON wartoscslownik(id_wartoscslownik)";
                cmd.ExecuteNonQuery();
                result = true;
            } catch(Exception ex)
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
                cmd.CommandText = "delete from wartoscslownik where id_wartoscslownik = @id_wartoscslownik";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SQLiteParameter("@id_wartosclownik", id));
                cmd.ExecuteNonQuery();
                result = true;
            } catch (Exception ex)
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
                cmd.CommandText = "insert into wartoscslownik(id_slownik, wartosc)"
                    + " values(@id_slownik, @wartosc)";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SQLiteParameter("@id_slownik", dane[0]));
                cmd.Parameters.Add(new SQLiteParameter("@wartosc", dane[1]));
                cmd.ExecuteNonQuery();
                result = true;
            } catch(Exception ex)
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
                cmd.CommandText = "update wartoscslownik set id_slownik = @id_slownik, "
                    + " wartosc = @wartosc "
                    + " where id_wartoscslownik = @id_wartoscslownik";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SQLiteParameter("@id_slownik", dane[0]));
                cmd.Parameters.Add(new SQLiteParameter("@wartosc", dane[1]));
                cmd.Parameters.Add(new SQLiteParameter("@id_wartoscslownik", dane[2]));
                cmd.ExecuteNonQuery();
                result = true;
            } catch( Exception ex)
            {
                result = false;
            }
            return result;
        }
    }
}
