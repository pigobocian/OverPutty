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
    /// Tabela główna - stąd startuje aplikacja
    /// </summary>
    internal class DBTableMain : IDBTable
    {
        private SQLiteCommand cmd;

        public DBTableMain(SQLiteCommand cmd)
        {
            this.cmd = cmd;
        }

        public bool createTable()
        {
            bool result = false;
            try
            {
                cmd.CommandText = "CREATE TABLE IF NOT EXISTS main ( "
                    + "id_main INTEGER PRIMARY KEY AUTOINCREMENT,"
                    + "id_nazwauslugi INTEGER,"
                    + "nazwa TEXT,"
                    + "aplikacja TEXT," // nazwa pliku do uruchomienia wraz ze ścieżką
                    + "opis TEXT,"
                    + "FOREIGN KEY(id_nazwauslugi) REFERENCES nazwauslugi(id_nazwauslugi)"
                    + ")";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE INDEX IF NOT EXISTS main_id ON main(id_main)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE INDEX IF NOT EXISTS main_nazwa ON main(nazwa COLLATE NOCASE)";
                cmd.ExecuteNonQuery();
                result= true;
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
                cmd.CommandText = "delete from main where id_main = @id_main";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SQLiteParameter("@id_main", id));
                cmd.ExecuteNonQuery();
                result = true;
            } catch( Exception ex )
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
                cmd.CommandText = "insert into main (id_nazwauslugi, nazwa, aplikacja, opis "
                    + " values (@id_nazwauslugi, @nazwa, @aplikacja, @opis";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SQLiteParameter("@id_nazwauslugi", dane[0]));
                cmd.Parameters.Add(new SQLiteParameter("@nazwa", dane[1]));
                cmd.Parameters.Add(new SQLiteParameter("@aplikacja", dane[2]));
                cmd.Parameters.Add(new SQLiteParameter("@opis", dane[3]));
                cmd.ExecuteNonQuery();
                result = true;
            } catch ( Exception e)
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
                cmd.CommandText = "update main set id_nazwauslugi = @id_nazwauslugi, "
                    + " nazwa = @nazwa, "
                    + " aplikacja = @aplikacja "
                    + " opis = @opis";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SQLiteParameter("@id_nazwauslugi", dane[0]));
                cmd.Parameters.Add(new SQLiteParameter("@nazwa", dane[1]));
                cmd.Parameters.Add(new SQLiteParameter("@aplikacja", dane[2]));
                cmd.Parameters.Add(new SQLiteParameter("@opis", dane[3]));
                cmd.ExecuteNonQuery(); 
                result = true;
            } catch (Exception e)
            {
                result = false;
            }
            return result;
        }
    }
}
