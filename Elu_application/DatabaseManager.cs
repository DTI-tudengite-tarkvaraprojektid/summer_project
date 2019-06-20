using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Xamarin.Forms;

namespace Elu_application
{
    public class DatabaseManager
    {
        public SQLiteConnection dbConnection;
        public DatabaseManager()
        {
            dbConnection = DependencyService.Get<IDBInterface>().CreateConnection();
        }

        /// "Select * From [Card] WHERE (UniKood LIKE '#NEG%' OR Unikood LIKE '#POS%')"


        public List<Cards> GetAllPositiveCards()
        {
            return dbConnection.Query<Cards>("Select * From [Card] WHERE UniKood LIKE '#POS%'");

        }

        public List<Cards> GetAllNegativeCards()
        {
            return dbConnection.Query<Cards>("Select * From [Card] WHERE UniKood LIKE '#NEG%'");
        }

        public List<Cards> GetAllDevolepmentCards()
        {
            return dbConnection.Query<Cards>("Select * From [Card] WHERE UniKood LIKE '#ARE%'");

        }

        public List<Cards> GetAllServiceCards()
        {
            return dbConnection.Query<Cards>("Select * From [Card] WHERE UniKood LIKE '#OST%'");

        }

        public List<Cards> GetAllActionCards()
        {
            return dbConnection.Query<Cards>("Select * From [Card] WHERE UniKood LIKE '#TEG%'");
        }

        public List<Cards> GetAllMainCards()
        {
            return dbConnection.Query<Cards>("Select * From [Card] WHERE (UniKood LIKE '#ARE%' OR UniKood LIKE '#OST%' OR UniKood LIKE '#TEG%')");
        }

        public int SaveCards(Cards aCards)

        {
            return dbConnection.Insert(aCards);
        }
    }
}