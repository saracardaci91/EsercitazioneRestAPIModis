﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModisAPI.Models
{
    public class Studente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        
        public string Cognome { get; set; }
        public string Indirizzo { get; set; }
        public IList<StudenteCorso> StudenteCorsi { get; set; }

       

    }
}
