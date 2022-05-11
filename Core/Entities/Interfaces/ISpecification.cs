using System.Linq.Expressions;

namespace Core.Entities.Interfaces
{
    public interface ISpecification<T>
    {
         Expression<Func<T, bool>> Criteria {get; }
         List<Expression<Func<T, object>>>Includes {get; }
         
    }
}