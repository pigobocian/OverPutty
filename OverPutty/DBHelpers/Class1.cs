using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverPutty.DBHelpers
{
    internal class DBTableParametr
    {
        private SQLiteCommand cmd;
        public DBTableParametr(SQLiteCommand cmd)
        {
            this.cmd = cmd;
        }

        public void CreateTableOperation()
        {

        }
    }
}
