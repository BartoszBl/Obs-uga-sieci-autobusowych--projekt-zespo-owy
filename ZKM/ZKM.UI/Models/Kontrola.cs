using System.ComponentModel.DataAnnotations;

namespace ZKM.UI.Models
{
    public class Kontrola
    {
        [Display(Name = "Numer kontroli")]
        public int KontrolaID { get; set; }
        [Required(ErrorMessage = "Musisz wybrać nazwę przystanku")]
        [Display(Name = "Nazwa przystanku")]
        public string Nazwa_przystanku { get; set; }
        [Required(ErrorMessage = "Musisz podać datę kontroli")]
        //[DisplayFormat(DataFormatString ="{0:dd/MM/yyyy hh:mm:ss tt}")]
        //[DisplayFormat(DataFormatString  = "{0:dd/MM/yyyy}")]
        [RegularExpression(@"^[0-9]{1,2}-[0-9]{1,2}-[0-9]{4}$")]
        public string Data { get; set; }
        [Required(ErrorMessage = "Musisz podać godzinę kontroli")]
        //[DisplayFormat(DataFormatString = "{0:tt:mm tt}")]
        //[RegularExpression(@"^[0-2]{1}[0-9]{1}:[0-5]{1}[0-9]{1}$")]
        public string Godzina { get; set; }
        [Required(ErrorMessage = "Musisz podać ilość skasowanych biletów")]
        [Display(Name = "Skasowane bilety")]
        public int Ilosc_skasowanych_biletow { get; set; }
        [Required(ErrorMessage = "Musisz podać ilość wystawionych mandatów")]
        [Display(Name = "Wystawione mandaty")]
        public int Ilosc_wystawionych_mandatow { get; set; }
        //[Required(ErrorMessage = "Musisz wybrać z listy odpowiedni rodzaj incydentu")]
        [Display(Name = "Incydent")]
        public string Opis_zdarzenia { get; set; }
    }
}