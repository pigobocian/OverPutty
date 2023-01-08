using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverPutty.DBHelpers
{
    internal interface IDBTable
    {
        bool createTable();
        bool insert(params object[] dane);
        bool update(int id, params object[] dane);
        bool delete(int id);

    }
}
