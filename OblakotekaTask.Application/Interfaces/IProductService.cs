using OblakotekaTask.Domain.Entities;
using OblakotekaTask.Domain.ViewModels.ProductModels;

namespace OblakotekaTask.Application.Interfaces
{
    public interface IProductService
    {
        Task<Product> Create(CreateProductViewModel vm);
        Task<Product> Update(ProductViewModel vm);
        Task Delete(Guid id);
        Task<IEnumerable<ProductViewModel>> GetAll();
        Task<IEnumerable<ProductViewModel>> GetAllByName(string name);
        Task<ProductViewModel> GetById(Guid id);
    }
}
