using System.ComponentModel.DataAnnotations;

namespace ZKM.UI.Models
{
    public class Przystanek
    {
        [Display(Name = "Numer przystanku")]
        public int PrzystanekID { get; set; }
        [Display(Name = "Nazwa przystanku")]
        public string Nazwa { get; set; }
        [Display(Name = "Szerokość geograf.")]
        public double Szerokosc_Geograficzna { get; set; }
        [Display(Name = "Długość geograf.")]
        public double Dlugosc_Geograficzna { get; set; }
        [Display(Name = "Aktywny?")]
        public bool Czy_Aktywny { get; set; }
        [Display(Name = "Przeniesiony?")]
        public bool Czy_Przeniesiony { get; set; }
        [Display(Name = "Kiosk?")]
        public bool Czy_jest_kiosk { get; set; }
        [Display(Name = "Tablica?")]
        public bool Czy_jest_tablica { get; set; }
        [Display(Name = "Usunięty?")]
        public bool Czy_Usuniety { get; set; }
    }
}