using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities;

namespace DAL
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            //seed metodu veritabanı oluştuktan sonra çalışır
            if (!context.Users.Any()) //eğer veritabanında hiç kullanıcı yoksa
            {
                context.Users.Add(
                    new User
                    {
                        CreateDate = DateTime.Now,
                        Email = "admin@siparistakip.com",
                        IsActive = true,
                        Name = "admin",
                        Password = "123456",
                        UserName = "admin"
                    }
                    );
                context.SaveChanges();
            }
            base.Seed(context);
        }
    }
}
