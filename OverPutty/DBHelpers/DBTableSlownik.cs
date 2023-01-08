using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverPutty.DBHelpers
{
    internal class DBTableSlownik : IDBTable
    {
        private SQLiteCommand cmd;

        public DBTableSlownik(SQLiteCommand cmd)
        {
            this.cmd = cmd;
        }

        public bool createTable()
        {
            bool result = false;
            try
            {
                cmd.CommandText = "CREATE TABLE IF NOT EXISTS slownik ( "
                    + "id_slownik INTEGER PRIMARY KEY AUTOINCREMENT,"
                    + "opis text,"
                    + ")";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE INDEX IF NOT EXISTS slownik_id ON slownik(id_slownik)";
                cmd.ExecuteNonQuery();
                result = true;
            } catch (Exception e)
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
                cmd.CommandText = "delete from slownik where id_slownik = @id_slownik";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SQLiteParameter("@id_slownik", id));
                cmd.ExecuteNonQuery();
                result = true;
            } catch(Exception ex)
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
                cmd.CommandText = "inster into slownik(opis) values(@opis)";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SQLiteParameter("@opis", dane[0]));
                cmd.ExecuteNonQuery();
                result = true;
            } catch (Exception ex)
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
                cmd.CommandText = "update slownik set opis = @opis where id_sklownik = @id_slownik";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SQLiteParameter("@opis", dane[0]));
                cmd.Parameters.Add(new SQLiteParameter("id_slownik", dane[1]));
                cmd.ExecuteNonQuery();
                result = true;
            } catch(Exception ex)
            {
                result = false;
            }
            return result;
        }
    }
}
