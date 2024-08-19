using Beaver.Domain.Entities;

namespace Beaver.Domain.Interfaces.IRepositories
{
    public interface IFormRepository : IBaseRepository<Form>
    {
        Task<List<Form>> GetAll(CancellationToken cancellationToken);
    }
}
