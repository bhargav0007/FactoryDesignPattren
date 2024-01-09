using DataAccessLayer.Interface;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories;


namespace DataAccessLayer
{
    public class RepositoryFactory
    {
        private readonly ProductDbContext _context;
        public RepositoryFactory(ProductDbContext context)
        {
            _context = context;
        }
        public IRepository<T> CreateRepository<T>()
        {
            if (typeof(T) == typeof(Product))
            {
                return new ProductRepository(_context) as IRepository<T>;
            }

            throw new InvalidOperationException("Unsupported repository type");
        }
    }
}
