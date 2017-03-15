using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace ZKM.UI.Models
{
    public class Autobus
    {
        [Display(Name = "Numer autobusu")]
        public int AutobusID { get; set; }
        [Display(Name = "Nr rejestracyjny")]
        public string Numer_Rejestracyjny { get; set; }
        public string Marka { get; set; }
        [Display(Name = "Rok produkcji")]
        public int Rok_Produkcji { get; set; }
        [Display(Name = "Ilość miejsc")]
        public int Ilosc_miejsc { get; set; }
        [Display(Name = "Klimatyzacja?")]
        public bool Klimatyzacja { get; set; }
        [Display(Name = "Aktywny?")]
        public bool Czy_Aktywny { get; set; }
        [Display(Name = "W naprawie?")]
        public bool Czy_W_naprawie { get; set; }
        [Display(Name = "Usunięty?")]
        public bool Czy_usuniety { get; set; }
        [Display(Name = "Zezłomowany?")]
        public bool Czy_zezlomowany { get; set; }
    }
}