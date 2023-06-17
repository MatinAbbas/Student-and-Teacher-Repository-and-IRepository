using System.Linq.Expressions;

namespace Student_and_Teacher_Repository_and_IRepository
{
    public interface IRepository<T> where T : class 
    {
        T GetByid(int Id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entites);
        
    }
    

    }

