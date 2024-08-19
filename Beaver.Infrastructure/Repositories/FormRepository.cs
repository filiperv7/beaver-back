using Beaver.Domain.Entities;
using Beaver.Domain.Interfaces.IRepositories;
using Beaver.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Beaver.Infrastructure.Repositories
{
    public class FormRepository : BaseRepository<Form>, IFormRepository
    {
        public FormRepository(AppDbContext context) : base(context)
        {}

        public async Task<List<Form>> GetAll(CancellationToken cancellationToken)
        {
            return await Context.Forms.ToListAsync(cancellationToken);
        }
    }
}
