using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAllProducts();
        Task<T> GetProductById(int id);
        Task<Product> AddProduct(T product);
        Task<bool> UpdateProduct(T product);
        Task<bool> DeleteProduct(int id);
    }
}
