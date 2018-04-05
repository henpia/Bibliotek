using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bibliotek.Models
{
    public class Bog
    {
        public int BogId { get; set; }
        public string Titel { get; set; }
        public string Beskrivelse { get; set; }
        public string ImageURL { get; set; }

        // Links til Genre- og Forfatter-tabeller
        public int GenreId { get; set; }
        public int ForfatterId { get; set; }

    }
}