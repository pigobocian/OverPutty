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
    /// wartości cech, pole wblob jest przeznaczone na przechowywanie
    /// zawartosci plików, np. pliku klucza prywtnego SSH
    /// i jesli wartość != null to jest dołączona tuz za WARTOSC 
    /// poprzedzona polem ROZDZIEL, czyli:
    /// WARTOSCROZDZELABLOB
    /// pole rozdziel bedzie przyjmować np. wartość spacji, znaku = itd ...
    /// </summary>
    internal class DBTableWystcecha : IDBTable
    {
        private SQLiteCommand cmd;

        public DBTableWystcecha(SQLiteCommand cmd)
        {
            this.cmd = cmd;
        }

        public bool createTable()
        {
            bool result = false;
            try
            {
                cmd.CommandText = "CREATE TABLE IF NOT EXISTS wystcecha ( "
                    + "id_wystcecha PRIMARY KEY AUTOINCREMENT,"
                    + "id_main INTEGER,"
                    + "id_cecha INTEGER,"
                    + "wartosc TEXT,"
                    + "rozdziel TEXT,"
                    + "ablob BLOB,"
                    + "opis TEXT,"
                    + "FOREIGN KEY(id_cecha) REFERENCES cecha(id_cecha)"
                    + "FOREIGN KEY(id_main) REFERENCES main(id_main)"
                    + ")";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE INDEX IF NOT EXISTS wystcecha_id ON wystcecha(id_wystcecha)";
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
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
                cmd.CommandText = "delete from wystcecha where id_wystcecha = @id_wystcecha";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SQLiteParameter("@id_wystcecha", id));
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
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
                cmd.CommandText = "insert into wystcecha(id_main, id_cecha, wartosc, "
                    + "rozdziel, ablob, opis "
                    + "values(@id_main, @id_cecha, @wartosc, @rozdziel, @ablob, @opis)";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SQLiteParameter("@id_main", dane[0]));
                cmd.Parameters.Add(new SQLiteParameter("@id_cecha", dane[1]));
                cmd.Parameters.Add(new SQLiteParameter("@wartosc", dane[2]));
                cmd.Parameters.Add(new SQLiteParameter("@rozdziel", dane[3]));
                cmd.Parameters.Add(new SQLiteParameter("@ablob", dane[4]));
                cmd.Parameters.Add(new SQLiteParameter("@opis", dane[5]));
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
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
                cmd.CommandText = "update wystcecha set id_main = @id_main, "
                    + " id_cecha = @id_cecha, wartosc = @wartosc, rozdziel = @rozdziel, "
                    + " ablob = @ablob, opis = @opis "
                    + " where id_wystcecha = @id_wystcecha";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SQLiteParameter("@id_main", dane[0]));
                cmd.Parameters.Add(new SQLiteParameter("@id_cecha", dane[1]));
                cmd.Parameters.Add(new SQLiteParameter("@wartosc", dane[2]));
                cmd.Parameters.Add(new SQLiteParameter("@rozdziel", dane[3]));
                cmd.Parameters.Add(new SQLiteParameter("@ablob", dane[4]));
                cmd.Parameters.Add(new SQLiteParameter("@opis", dane[5]));
                cmd.Parameters.Add(new SQLiteParameter("@id_wystcecha", id));
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }
    }
}
