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

        public Genre Genre { get; set; }
        public Forfatter Forfatter { get; set; }

    }
}