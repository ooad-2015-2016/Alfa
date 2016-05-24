﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PogrebnoDrustvo.DataBase.Models
{
    public class Izvjestaj
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//dodatno u donosu na dijagram klasa zbog kljuca
        public int idIzvjestaja { get; set; }
        public List<Radnik> radnici { get; set; }
        public List<Vozac> vozaci { get; set; }
        public int brojUkopanih { get; set; }
        public int brojKorisnika { get; set; }
        public double mjesecnaZarada { get; set; }
        public double mjesecniTroskovi { get; set; }
        public List<Zahtjev> mjesecniZahtjevi { get; set; }

        
    }
}
