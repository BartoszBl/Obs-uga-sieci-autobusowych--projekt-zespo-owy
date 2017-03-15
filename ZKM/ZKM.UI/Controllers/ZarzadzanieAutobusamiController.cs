//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using ZKM.UI.Models;

//namespace ZKM.UI.Controllers
//{
//    public class ZarzadzanieAutobusamiController : Controller
//    {
//        // GET: ZarzadzanieAutobusami
//        public ActionResult Index()
//        {
//            List<ZarzadzanieAutobusami> Autobusy = new List<ZarzadzanieAutobusami>();
//            SqlCommand query = new SqlCommand("index_Autobusy", Conn.Instance.DBConnection);
//            query.CommandType = System.Data.CommandType.StoredProcedure;
//            SqlDataReader reader = query.ExecuteReader();
//            while (reader.Read())
//            {
//                ZarzadzanieAutobusami nowy = new ZarzadzanieAutobusami();
//                nowy.id = (int)reader[0];
//                nowy.Marka = (string)reader[1];
//                nowy.Ilosc_miejsc = (string)reader[2];
//                nowy.Klimatyzacja = (string)reader[3];
//                nowy.Czy_Aktywny = (bool)reader[4];
//                nowy.Czy_W_naprawie = (bool)reader[5];
//                nowy.Czy_usuniety = (bool)reader[6];
//                nowy.Czy_zezlomowany = (bool)reader[7];
//            }
//            reader.Close();
//            return View(Autobusy);
//        }


//        // GET: ZarzadzanieAutobusami/Details/5
//        public ActionResult Details(int id)
//        {
//            ZarzadzanieAutobusami Autobusy = new ZarzadzanieAutobusami();
//            SqlCommand query = new SqlCommand("select_Autobusy", Conn.Instance.DBConnection);
//            query.CommandType = System.Data.CommandType.StoredProcedure;
//            query.Parameters.Add("@param1", id);
//            SqlDataReader reader = query.ExecuteReader();
//            while (reader.Read())
//            {
//                Autobusy.id = (int)reader[0];
//                Autobusy.Marka = (string)reader[1];
//                Autobusy.Ilosc_miejsc = (string)reader[2];
//                Autobusy.Klimatyzacja = (string)reader[3];
//                Autobusy.Czy_Aktywny = (bool)reader[4];
//                Autobusy.Czy_W_naprawie = (bool)reader[5];
//                Autobusy.Czy_usuniety = (bool)reader[6];
//                Autobusy.Czy_zezlomowany = (bool)reader[7];
//            }
//                reader.Close();
//                return View(Autobusy);
//        }






//                return View();
//        }
//    }
//}