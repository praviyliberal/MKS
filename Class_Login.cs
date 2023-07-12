using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public class Class_Login
    {
        public static string users_login { get; set; }

        public static int Id_users { get; set; } // текущий пользователь

        public static string Fname { get; set; }
        public static string Sname { get; set; }
        public static string FAname { get; set; }

        public static int IdProduct { get; set; } //вид товара
        public static int Id { get; set; } // конкретный товар
        public static int Id_Order { get; set; }
        public static bool role { get; set; } // роль

    }
}
