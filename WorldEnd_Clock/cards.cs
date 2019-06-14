using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace WorldEnd_Clock
{
   public class Cards
    {
        [PrimaryKey, AutoIncrement]
        public /* int */ string Id { get; set; }
        public string Kategooria { get; set; }
        public string Loodusvarad { get; set; }
        public string Nimetus { get; set; }
        public string/* int */ Elustik { get; set; }
        public string/* int */ Turism { get; set; }
        public string/* int */ Rahuolu { get; set; }
        public /* int */ string Skoor { get; set; }
        public string Kirjeldus { get; set; }
        public /* int */ string Markide_arv { get; set; }


    }
}
