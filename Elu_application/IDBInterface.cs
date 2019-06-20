using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Elu_application
{
	public interface IDBInterface
	{
		SQLiteConnection CreateConnection();
	}
}