using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Data.SQLite;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverPutty.DBHelpers
{
    /// <summary>
    /// Klasa reprezentuje tabelę PARAMETR
    /// Sama tabela odpowiada za przechowywanie parametrów przekazywanych
    /// do uruchamianej aplikacji
    /// </summary>
    internal class DBTableParametr:IDBTable
    {
        private SQLiteCommand cmd;

        /// <summary>
        /// Konstruktor inicjuje tylko jedno pole służące wykonywaniu poleceń
        /// </summary>
        /// <param name="connection">
        /// Do parametru należy przekazać otwarte już połączenie z bazą danych
        /// </param>
        public DBTableParametr(SQLiteConnection connection)
        {
            this.cmd = connection.CreateCommand();
        }

        /// <summary>
        /// Tworzy w bezpieczny sposób tabelę, tzn. utworzy ją tylko wówczas gdy nie istnieje
        /// </summary>
        /// <returns>
        /// true jeślii pomyślenie uworzono tabelę, w przeciwnym razie false
        /// </returns>
        public bool createTable()
        {
            bool result = false;
            try
            {
                cmd.CommandText = "CREATE TABLE IF NOT EXISTS parametr ( "
                    + "id_parametr INTEGER PRIMARY KEY AUTOINCREMENT,"
                    + "parametr TEXT"
                    + ")";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE INDEX IF NOT EXISTS parametr_id ON parametr(id_parametr)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE INDEX IF NOT EXISTS parametr_parametr ON parametr(parametr COLLATE NOCASE)";
                cmd.ExecuteNonQuery();
                result = true;
            } catch (Exception ex)
            {
                result= false;
            }
            return result;
        }

        public bool insert(params object[] dane)
        {
            bool result = false;
            try
            {
                cmd.CommandText = "insert into parametr(parametr) values(@parametr)";
                cmd.Parameters.Add(new SQLiteParameter("@parametr", dane[0]));
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
                cmd.CommandText = "update parametr set paarametr = @parametr "
                    + " where id_marametr = @id_parametr";
                cmd.Parameters.Add(new SQLiteParameter("@parametr", dane[0]));
                cmd.Parameters.Add(new SQLiteParameter("@id_parametr", dane[1]));
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
                cmd.CommandText = "delete from parametr where id_parametr = @id_parametr";
                cmd.Parameters.Add(new SQLiteParameter("@id_parametr", id));
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
