using System.Collections.Generic;

namespace SpaceProject.Data.Repository
{
    public interface IRepository<T> where T:class
    {
            void Insert(T item);
            void Update(T item);
            T GetById(int id);

            List<T> GetAll();
            void Delete(int id);
        
    }
}