﻿using DataAccessLayer.Interface;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;


namespace DataAccessLayer.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private readonly ProductDbContext _context;

        public ProductRepository(ProductDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<Product> AddProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<bool> UpdateProduct(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
                return false;

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
