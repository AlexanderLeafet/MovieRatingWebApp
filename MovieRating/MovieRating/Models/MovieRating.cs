using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRating.Models
{
    public class MovieRating
    {
        //PK
        public int ID { get; set; }
        public string PersonName { get; set; }
        public int Rating { get; set; }
        //FK
        public int MovieID { get; set; }
    }
}