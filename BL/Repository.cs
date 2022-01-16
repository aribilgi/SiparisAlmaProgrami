using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Repository<T> : IRepository<T> where T : class, IEntity, new()
    {
        DatabaseContext context;
        DbSet<T> _objectSet;
        public Repository()
        {
            if (context == null) // Eğer context null ise
            {
                context = new DatabaseContext(); // yeni bir DatabaseContext nesnesi oluştur
                _objectSet = context.Set<T>(); //_objectSet nesnesini context e gelen class a ayarla
            }
        }
        public int Add(T entity)
        {
            _objectSet.Add(entity);
            return SaveChanges();
        }

        public int Delete(T entity)
        {
            _objectSet.Remove(entity);
            return SaveChanges();
        }

        public T Find(int id)
        {
            return _objectSet.Find(id);
        }

        public List<T> GetAll()
        {
            return _objectSet.ToList();
        }

        public int SaveChanges()
        {
            return context.SaveChanges();
        }

        public int Update(T entity)
        {
            _objectSet.AddOrUpdate(entity);
            return SaveChanges();
        }
    }
}
