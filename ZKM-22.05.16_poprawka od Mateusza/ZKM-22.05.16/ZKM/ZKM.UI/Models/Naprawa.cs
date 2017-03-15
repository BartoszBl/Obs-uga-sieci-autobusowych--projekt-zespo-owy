using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZKM.UI.Models
{
    public class Naprawa
    {
        [Display(Name = "Numer naprawy")]
        public int NaprawaID { get; set; }
        [Display(Name = "Numer autobusu")]
        public int AutobusID { get; set; }
        [Display(Name = "Data rozpoczęcia naprawy")]
        public DateTime Data_rozpoczecia { get; set; }
        [Display(Name = "Data zakończenia naprawy")]
        public DateTime Data_zakonczenia { get; set; }
        // [Display(Name = "Rodzaj naprawy")]
        //public Rodzaj Rodzaj_naprawy { get; set; }

        [Display(Name = "Czy w naprawie")]
        public bool Czy_W_naprawie { get; set; }

        public enum Rodzaj
        {
            opony,
            silnik,
            olej,
            hamulce,
            zawieszenie,
            akumulator
        }






    }
}