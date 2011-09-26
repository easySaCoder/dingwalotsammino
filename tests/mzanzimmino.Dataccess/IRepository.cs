using System.Collections.Generic;

namespace SaLyrics.DataLayer {
    public interface IRepository<T, K> {

        void Add(T entity);
        T FindById(K id);
        List<T> GetAll();
        void Update(T entity);
        void Delete(T entity);
    }
}