using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bibliotek.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Navn { get; set; }

        public IList<Bog> Boeger { get; set; }
    }
}