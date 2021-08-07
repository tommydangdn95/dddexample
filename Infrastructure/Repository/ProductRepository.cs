using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _dbContext;

        public ProductRepository(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task CreateProductAsync(Product product)
        {
            await this._dbContext.Products.AddAsync(product);
            await this._dbContext.SaveChangesAsync();
        }
    }
}
