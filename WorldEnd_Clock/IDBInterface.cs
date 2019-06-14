using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace WorldEnd_Clock
{
    public interface IDBInterface
    {
        SQLiteConnection CreateConnection();
    }
}
