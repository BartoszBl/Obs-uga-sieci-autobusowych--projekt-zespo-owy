using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZKM.UI.Models
{
    public class Incydent
    { 
        [Display(Name = "ID Incydentu")]
        public int ID { get; set; }
        [Display(Name = "Nazwa Incydentu")]
        public string Nazwa { get; set; }
    }
}