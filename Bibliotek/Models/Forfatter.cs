using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bibliotek.Models
{
    public class Forfatter
    {
        public int ForfatterId { get; set; }
        public string Navn { get; set; }
        public string Beskrivelse { get; set; }

        public ICollection<Bog> Boeger { get; set; }
    }
}