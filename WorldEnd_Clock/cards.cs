using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace WorldEnd_Clock
{
   public class Cards
    {
        [PrimaryKey, AutoIncrement]
        public string Id { get; set; }
        public string UniKood { get; set; }
        public string Kategooria { get; set; }
        public string Loodusvarad { get; set; }
        public string Nimetus { get; set; }
        public string Elustik { get; set; }
        public string Turism { get; set; }
        public string Rahuolu { get; set; }
        public string Skoor { get; set; }
        public string Kirjeldus { get; set; }
        public string Markide_arv { get; set; }
        public bool Used { get; set; }


        }


    }
