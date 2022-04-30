using Entities;
using System.Data.Entity;

namespace DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
            Database.SetInitializer(new DbInitializer());
            // Eğer veritabanı model classlarında bir değişiklik yaptıktan sonra veri kaybı olmadan veritabanını güncellemek istersek Entity framework migration yapısını kullanmamız gerekir!!!
            // Bu yapıyı kullanmak için Package manager console ekranını açıp (Eğer visual studio ekranında package manager console ekranı yoksa üst menüden Tools > Nuget package manager > Package manager console menüsüne tıklayarak açabiliriz) Default Project kısmından DAL projesini seçmeliyiz!
            // Sonrasında kod yazma kısmına tıklayıp enable-migrations komutunu yazıp enter ile çalıştırmalıyız.
            // Migrationu bu şekilde aktif ettikten sonra yeni bir değişiklik yaparsak artık sadece add-migration migrationismi komutu ile bu değişiklikler için migration oluşturabiliriz enable-migration sadece ilk seferinde gerekli!
            // son olarak classlardaki bu değişikliği veritabanına yansıtmak için update-database komutunu yazıp enter diyerek çalıştırmalıyız.
            // Eğer bir hata çıkarsa ekranda yazacaktır çıkmazsa done PM şeklinde komut satırı gelecektir.
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Log> Logs { get; set; }
    }
}
