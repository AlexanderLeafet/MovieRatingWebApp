using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRating.Models
{
    public class MovieInfo
    {
        public int ID { get; set; }
        public int Place { get; set; }
        public string Movie { get; set; }
        public string URL { get; set; }
        public double rating { get; set; }
        public int TotalVotes { get; set; }
    }
}