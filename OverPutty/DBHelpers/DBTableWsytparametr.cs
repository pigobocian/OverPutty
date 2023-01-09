using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverPutty.DBHelpers
{
    /// <summary>
    /// Występowanie parametrów aplikacji, każda aplikacja może mieć dowolnie
    /// wiele różnych parametrów uruchowmienia
    /// </summary>
    internal class DBTableWsytparametr : IDBTable
    {
        private SQLiteCommand cmd;

        public DBTableWsytparametr(SQLiteCommand cmd)
        {
            this.cmd = cmd;
        }

        public bool createTable()
        {
            bool result = false;
            try
            {
                cmd.CommandText = "CREATE TABLE IF NOT EXISTS wystparametr ("
                    + "id_wystparametr INTEGER PRIMARY KEY AUTOINCREMENT,"
                    + "id_paramter INTEGER,"
                    + "id_main INTEGER,"
                    + "FOREIGN KEY(id_parametr) REFERENCES parametr(id_parametr),"
                    + "FOREIGN KEY(id_main) REFERENCES main(id_main)"
                    + ")";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE INDEX IF NOT EXISTS wystparametr_id ON wystparametr(id_wystparametr)";
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
                cmd.CommandText = "delete from wystmarametr where id_wystparametr = @id_wystparametr";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SQLiteParameter("@id_wsytparametr", id));
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
                cmd.CommandText = "inster into wystparametr(id_parametr, id_main) "
                    + " values (@id_parametr, @id_main)";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SQLiteParameter("@id_parametr", dane[0]));
                cmd.Parameters.Add(new SQLiteParameter("@id_main", dane[1]));
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
                cmd.CommandText = "update wystparametr set id_parametr = @id_parametr, "
                    + " id_main = @id_main "
                    + " where id_wystparametr = @id_wystparametr";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SQLiteParameter("@id_parametr", dane[0]));
                cmd.Parameters.Add(new SQLiteParameter("@id_main", dane[1]));
                cmd.Parameters.Add(new SQLiteParameter("@id_wstparametr", dane[2]));4
                result = true;
            } catch(Exception ex)
            {
                result = false;
            }
            return result;
        }
    }
}
