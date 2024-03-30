using Microsoft.EntityFrameworkCore;
using OblakotekaTask.Application.Interfaces;
using OblakotekaTask.Domain.Entities;
using OblakotekaTask.Infrastructure.Interfaces;

namespace OblakotekaTask.Infrastructure.Repositories
{
    public class ProductRepository : IBaseRepository<Product>
    {
        private readonly ITestDbContext _context;

        public ProductRepository(ITestDbContext _context) =>
            this._context = _context;


        public async Task Create(Product entity, CancellationToken cancellationToken = default)
        {
            await _context.Products.AddAsync(entity);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task Delete(Product entity, CancellationToken cancellationToken = default)
        {
            _context.Products.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public IQueryable<Product> GetAll() => _context.Products.AsQueryable().AsNoTracking();

        public async Task<Product> GetById(Guid id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product == null)
                throw new Exception();
            return product;
        }

        public async Task<Product> Update(Product entity, CancellationToken cancellationToken = default)
        {
            _context.Products.Update(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity;
        }
    }
}
