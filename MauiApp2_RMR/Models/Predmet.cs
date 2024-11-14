using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2_RMR.Models
{
    internal class Predmet
    {
        public Guid predmetId { get; set; }
        public string Naziv { get; set; }
        public int ECTS { get; set; }
        public string Semester { get; set; }

        public Predmet(Guid id, string naziv, int ects, string sem)
        {
            predmetId = id;
            Naziv = naziv;
            ECTS = ects;
            Semester = sem;
        }
    }
}
