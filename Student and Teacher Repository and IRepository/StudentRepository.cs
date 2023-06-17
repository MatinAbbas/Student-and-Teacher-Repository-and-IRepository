using System.Linq.Expressions;
using Google;

namespace Student_and_Teacher_Repository_and_IRepository
{
    public class StudentRepository<T>:IRepository<T> where T : class
    {
        protected readonly ApplicationContext _context;
        public StudentRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);

        }
        public void DeleteRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);

        }
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
           return _context.Set<T>().Where(expression);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        public T GetByid(int Id)

        {
            var Find = _context.Set<T>().Find(Id);
            if (Find == null)
            {
                throw new ArgumentNullException("please check the id again");
            }
            else
            {
                return Find;
            }
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            _context.Set<T>().UpdateRange(entities);

        }
        private void ValidateContext(T entites)
        {
            if (_context == null)
                throw new ArgumentNullException(nameof(entites));
          
        }
    }
}
