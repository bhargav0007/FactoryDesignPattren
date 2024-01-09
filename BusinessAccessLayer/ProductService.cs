using DataAccessLayer;
using DataAccessLayer.Interface;
using DataAccessLayer.Models;
using System.Data;

namespace BusinessAccessLayer
{
    public class ProductService : IProductService
    {
        private readonly RepositoryFactory _repositoryFactory;
        private readonly IRepository<Product> _productRepository; 

        public ProductService(RepositoryFactory repositoryFactory)
        {
            _repositoryFactory = repositoryFactory;
            _productRepository = _repositoryFactory.CreateRepository<Product>();
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _productRepository.GetAllProducts();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _productRepository.GetProductById(id);
        }

        public async Task<Product> AddProduct(Product product)
        {
            return await _productRepository.AddProduct(product);
        }

        public async Task<bool> UpdateProduct(Product product)
        {
            return await _productRepository.UpdateProduct(product);
        }

        public async Task<bool> DeleteProduct(int id)
        {
            return await _productRepository.DeleteProduct(id);
        }
    }
}
