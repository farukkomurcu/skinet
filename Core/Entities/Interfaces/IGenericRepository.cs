namespace Core.Entities.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
         Task<T> GetByAsync(int id);
         Task<IReadOnlyList<T>>ListallAsync();
         Task<T> GetEntityWithSpec(ISpecification<T> spec);
         Task<IReadOnlyList<T>>ListAsync(ISpecification<T> spec);
    }
}