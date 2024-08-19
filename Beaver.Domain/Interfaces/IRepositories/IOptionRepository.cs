using Beaver.Domain.Entities;

namespace Beaver.Domain.Interfaces.IRepositories
{
    public interface IOptionRepository
    {
        void Create(Option entity);
        void Update(Option entity);
        void Delete(Option entity);
        Task<Option> Get(int idInput, CancellationToken cancellationToken);
    }
}
