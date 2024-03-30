using Ardalis.GuardClauses;
using Microsoft.EntityFrameworkCore;
using OblakotekaTask.Application.Interfaces;
using OblakotekaTask.Domain.Entities;
using OblakotekaTask.Domain.ViewModels.ProductModels;
using OblakotekaTask.Infrastructure.Interfaces;


namespace OblakotekaTask.Application.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IBaseRepository<Product> _productRepository;

        public ProductService(IBaseRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> Create(CreateProductViewModel vm)
        {
            var product = new Product()
            {
                Name = vm.Name,
                Description = vm.Description,
            };
            await _productRepository.Create(product);

            return product;
        }

        public async Task Delete(Guid id)
        {
            var existProduct = await _productRepository.GetById(id);
            Guard.Against.NotFound(id, existProduct, nameof(existProduct.Id));

            await _productRepository.Delete(existProduct);
        }

        public async Task<IEnumerable<ProductViewModel>> GetAll()
        {
            var products = await _productRepository
                .GetAll()
                .OrderBy(x => x.Name)
                .AsNoTracking()
                .ToListAsync();

            var data = products.Select(x => new ProductViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
            }).ToList();

            return data;
        }

        public async Task<IEnumerable<ProductViewModel>> GetAllByName(string name)
        {
            var products = await _productRepository
                .GetAll()
                .Where(x => x.Name == name)
                .OrderBy(x => x.Name)
                .AsNoTracking()
                .ToListAsync();

            var data = products.Select(x => new ProductViewModel
            {
                Name = x.Name,
                Description = x.Description
            }).ToList();

            return data;
        }

        public async Task<ProductViewModel> GetById(Guid id)
        {
            var product = await _productRepository.GetById(id);
            Guard.Against.NotFound(id, product, nameof(product.Id));

            var data = new ProductViewModel
            {
                Name = product.Name,
                Description = product.Description,
            };

            return data;
        }

        public async Task<Product> Update(ProductViewModel vm)
        {
            var existProduct = await _productRepository.GetAll()
                 .FirstOrDefaultAsync(p => p.Id == vm.Id);

            existProduct.Name = vm.Name;
            existProduct.Description = vm.Description;

            Guard.Against.NotFound(vm.Id, existProduct, nameof(existProduct.Id));

            var data = await _productRepository.Update(existProduct);

            return data;
        }
    }
}
