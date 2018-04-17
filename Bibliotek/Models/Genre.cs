using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bibliotek.Models
{
    [Table("Genre")]
    public class Genre
    {
        public int GenreId { get; set; }
        public string Navn { get; set; }

        public ICollection<Bog> Boeger { get; set; }
    }
}