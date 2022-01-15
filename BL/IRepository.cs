using System.Collections.Generic;

namespace BL
{
    interface IRepository<T> // <T> kullanarak interface i generic hale getirdik
    {
        List<T> GetAll();
        int Add(T entity);
        T Find(int id);
        int Update(T entity);
        int Delete(T entity);
        int SaveChanges();
    }
}
