using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverPutty.DBHelpers
{
    internal class DBTableCecha : IDBTable
    {
        private SQLiteCommand cmd;

        public DBTableCecha(SQLiteCommand cmd)
        {
            this.cmd = cmd;
        }

        public bool createTable()
        {
            bool result = false;
            try
            {
                cmd.CommandText = "CREATE TABLE IF NOT EXISTS cecha ( "
                    + "id_cecha INTEGER PRIMARY KEY AUTOINCREMENT,"
                    + "nazwa text,"
                    + "opis text,"
                    + "id_slownik INTEGER," // jesli != null to wskazuje na slownik z którego należey pobierać wartości
                    + "FOREIGN KEY(id_slownik) REFERENCES slownik(id_slownik)"
                    + ")";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE INDEX IF NOT EXISTS cecha_id ON cecha(id_cecha)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE INDEX IF NOT EXISTS cecha_nazwa ON cecha(nazwa COLLATE NOCASE)";
                cmd.ExecuteNonQuery();
                result = true;
            } catch (Exception ex)
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
                cmd.CommandText = "delete from cecha where id_cecha = @id_cecha";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SQLiteParameter("@id_cecha", id));
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
            bool result = true;
            try
            {
                cmd.CommandText = "inster into cecha(nazwa, opis, id_slownik) "
                    + " values(@nazwa, @opis, @id_slowniik)";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SQLiteParameter("@nazwa", dane[0]));
                cmd.Parameters.Add(new SQLiteParameter("@opis", dane[1]));
                cmd.Parameters.Add(new SQLiteParameter("@id_slownik", dane[2]));
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
                cmd.CommandText = "update cecha set nazwa = @nazwa, "
                    + " "
            }
        }
    }
}
