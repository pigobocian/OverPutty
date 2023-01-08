using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverPutty.IDBHelpers
{
    internal interface DBTable
    {
        bool createTable();
        bool insert(params object[] dane);
        bool update(int id, params object[] dane);
        bool delete(int id);

    }
}
