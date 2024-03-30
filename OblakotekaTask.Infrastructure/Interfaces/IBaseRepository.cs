namespace OblakotekaTask.Infrastructure.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task Create(T entity, CancellationToken cancellationToken = default);
        Task<T> Update(T entity, CancellationToken cancellationToken = default);
        Task Delete(T entity, CancellationToken cancellationToken = default);
        IQueryable<T> GetAll();
        Task<T> GetById(Guid id);
    }
}
