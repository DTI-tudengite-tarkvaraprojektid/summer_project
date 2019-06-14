using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Xamarin.Forms;

namespace WorldEnd_Clock
{
    public class DatabaseManager
    {
        public SQLiteConnection dbConnection;
        public DatabaseManager()
        {
            dbConnection = DependencyService.Get<IDBInterface>().CreateConnection();
        }

        public List<Cards> GetAllCards()
        {
            return dbConnection.Query<Cards>("Select * From [Card]");
        }

        public int SaveCards(Cards aCards)

        {
            return dbConnection.Insert(aCards);
        }
    }
}
