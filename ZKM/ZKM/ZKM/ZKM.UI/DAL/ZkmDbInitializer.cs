using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using ZKM.Core.Enums;
using ZKM.UI.Models;

namespace ZKM.UI.DAL
{
    public class ZkmDbInitializer : DropCreateDatabaseAlways<ZkmDbContext>
    {       
        protected override void Seed(ZkmDbContext context)
        {
            this.AddDefaultRoles(context);
            this.AddDefaultAdminUser(context);

            SeedStoreData(context);

            base.Seed(context);
        }

        private void SeedStoreData(ZkmDbContext context)
        {
            var przystanki = new List<Przystanek>
            {
                new Przystanek() {PrzystanekID = 1, Nazwa = "Dworzec Autobusowy", Szerokosc_Geograficzna = 53.784872, Dlugosc_Geograficzna = 20.498527, Czy_Aktywny = true, Czy_Przeniesiony = false, Czy_jest_kiosk = true, Czy_jest_tablica = false, Czy_Usuniety = false  },
                new Przystanek() {PrzystanekID = 2, Nazwa = "Stary Dwór", Szerokosc_Geograficzna = 53.744828, Dlugosc_Geograficzna = 20.455407, Czy_Aktywny = true, Czy_Przeniesiony = false, Czy_jest_kiosk = false, Czy_jest_tablica = false, Czy_Usuniety = false  },
                new Przystanek() {PrzystanekID = 3, Nazwa = "Plac Roosevelta", Szerokosc_Geograficzna = 53.772754, Dlugosc_Geograficzna = 20.474745, Czy_Aktywny = true, Czy_Przeniesiony = false, Czy_jest_kiosk = false, Czy_jest_tablica = true, Czy_Usuniety = false  },
                new Przystanek() {PrzystanekID = 4, Nazwa = "Armii Krajowej", Szerokosc_Geograficzna = 53.767464, Dlugosc_Geograficzna = 20.466358, Czy_Aktywny = true, Czy_Przeniesiony = false, Czy_jest_kiosk = true, Czy_jest_tablica = true, Czy_Usuniety = false  },
                new Przystanek() {PrzystanekID = 5, Nazwa = "Uniwersytet-Stadion", Szerokosc_Geograficzna = 53.754260, Dlugosc_Geograficzna = 20.461043, Czy_Aktywny = true, Czy_Przeniesiony = false, Czy_jest_kiosk = false, Czy_jest_tablica = false, Czy_Usuniety = false  }
            };

            przystanki.ForEach(p => context.Przystanki.Add(p));
            context.SaveChanges();

            var autobusy = new List<Autobus>
            {
                new Autobus() {AutobusID = 1, Numer_Rejestracyjny = "NO 6621", Marka = "Solaris", Rok_Produkcji = 1999, Ilosc_miejsc = 120, Klimatyzacja = true,  Czy_Aktywny = true, Czy_W_naprawie = false, Czy_usuniety = false, Czy_zezlomowany = false },
                new Autobus() {AutobusID = 2, Numer_Rejestracyjny = "NO 5423",Marka = "Solaris", Rok_Produkcji = 1990, Ilosc_miejsc = 70, Klimatyzacja = false,  Czy_Aktywny = false, Czy_W_naprawie = false, Czy_usuniety = false, Czy_zezlomowany = true },
                new Autobus() {AutobusID = 3, Numer_Rejestracyjny = "NOL 9351",Marka = "Neoplan", Rok_Produkcji = 2005, Ilosc_miejsc = 130, Klimatyzacja = true,  Czy_Aktywny = true, Czy_W_naprawie = true, Czy_usuniety = false, Czy_zezlomowany = false },

            };

            autobusy.ForEach(a => context.Autobusy.Add(a));
            context.SaveChanges();

            var kontrole = new List<Kontrola>
            {
              new Kontrola() {KontrolaID =1, Nazwa_przystanku = "Dworzec Autobusowy", Data = "06-05-2005", Godzina = "15:00", Ilosc_skasowanych_biletow = 70, Ilosc_wystawionych_mandatow = 4 },
              new Kontrola() {KontrolaID =2, Nazwa_przystanku = "Dworzec Autobusowy", Data = "06-05-2005", Godzina = "15:40", Ilosc_skasowanych_biletow = 62, Ilosc_wystawionych_mandatow = 2 },
              new Kontrola() {KontrolaID =3, Nazwa_przystanku = "Dworzec Autobusowy", Data = "06-05-2005", Godzina = "16:05", Ilosc_skasowanych_biletow = 49, Ilosc_wystawionych_mandatow = 1 },
              new Kontrola() {KontrolaID =4, Nazwa_przystanku = "Stary Dwór", Data = "06-05-2005", Godzina = "17:00", Ilosc_skasowanych_biletow = 31, Ilosc_wystawionych_mandatow = 1 },
              new Kontrola() {KontrolaID =5, Nazwa_przystanku = "Stary Dwór", Data = "06-05-2005", Godzina = "18:10", Ilosc_skasowanych_biletow = 42, Ilosc_wystawionych_mandatow = 2 },
              new Kontrola() {KontrolaID =6, Nazwa_przystanku = "Plac Roosevelta", Data = "07-05-2005", Godzina = "09:00", Ilosc_skasowanych_biletow = 62, Ilosc_wystawionych_mandatow = 2 },
              new Kontrola() {KontrolaID =7, Nazwa_przystanku = "Plac Roosevelta", Data = "07-05-2005", Godzina = "11:10", Ilosc_skasowanych_biletow = 34, Ilosc_wystawionych_mandatow = 0 },
              new Kontrola() {KontrolaID =8, Nazwa_przystanku = "Plac Roosevelta", Data = "07-05-2005", Godzina = "12:25", Ilosc_skasowanych_biletow = 53, Ilosc_wystawionych_mandatow = 1 },
              new Kontrola() {KontrolaID =9, Nazwa_przystanku = "Dworzec Autobusowy", Data = "07-05-2005", Godzina = "14:00", Ilosc_skasowanych_biletow = 28, Ilosc_wystawionych_mandatow =0 },
              new Kontrola() {KontrolaID =10, Nazwa_przystanku = "Dworzec Autobusowy", Data = "07-05-2005", Godzina = "14:32", Ilosc_skasowanych_biletow = 42, Ilosc_wystawionych_mandatow = 1 },
            };

            kontrole.ForEach(k => context.Kontrolas.Add(k));
            context.SaveChanges();

            var incydenty = new List<Incydent>
            {
              new Incydent() {ID =1, Nazwa = "Brak Incydentów"},
              new Incydent() {ID =2, Nazwa = "Zbita szyba"},
              new Incydent() {ID =3, Nazwa = "Skradziony śmietnik"},
              new Incydent() {ID =4, Nazwa = "Ucieczka"},
              new Incydent() {ID =5, Nazwa = "Mateusz pozdrawia!!!"}
            };

            incydenty.ForEach(k => context.Incydenty.Add(k));
            context.SaveChanges();
        }


        #region User Identity seed

        private void AddDefaultAdminUser(ZkmDbContext context)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            var defaultAdminAccountName = ConfigurationManager.AppSettings["DefaultAdminAccount"].ToString();
            var password = ConfigurationManager.AppSettings["DefaultAdminAccountPassword"].ToString();

            var user = new ApplicationUser { UserName = defaultAdminAccountName, Email = defaultAdminAccountName };

            var userCreationResult = userManager.Create(user, password);

            if (userCreationResult.Succeeded)
                userManager.AddToRole(user.Id, UserRoles.Manager);            
        }

        private void AddDefaultRoles(ZkmDbContext context)
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            if (!roleManager.RoleExists(UserRoles.Manager))
                roleManager.Create(new IdentityRole(UserRoles.Manager));

            if (!roleManager.RoleExists(UserRoles.Kontroler))
                roleManager.Create(new IdentityRole(UserRoles.Kontroler));
        }

        #endregion
    }
}