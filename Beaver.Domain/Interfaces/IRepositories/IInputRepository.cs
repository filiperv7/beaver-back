using Beaver.Domain.Entities;

namespace Beaver.Domain.Interfaces.IRepositories
{
    public interface IInputRepository : IBaseRepository<Input>
    {
        Task<List<Input>> GetAll(int idForm, CancellationToken cancellationToken);
    }
}
