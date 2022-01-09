using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BL
{
    public class UserManager
    {
        DatabaseContext context = new DatabaseContext(); // Kullanıcı işlemlerini yapabilmek için
        public List<User> GetAll() // Geriye kullanıcı listesi döndüren metot
        {
            return context.Users.ToList(); //DatabaseContext teki kullanıcı listesini döndür
        }
    }
}
