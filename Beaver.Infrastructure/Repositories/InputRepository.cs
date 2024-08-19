using Beaver.Domain.Entities;
using Beaver.Domain.Interfaces.IRepositories;
using Beaver.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beaver.Infrastructure.Repositories
{
    public class InputRepository : BaseRepository<Input>, IInputRepository
    {
        public InputRepository(AppDbContext context) : base(context)
        { }

        public async Task<List<Input>> GetAll(int idForm, CancellationToken cancellationToken)
        {
            return await Context.Inputs.Where(x => x.Form.Id == idForm).ToListAsync(cancellationToken);
        }
    }
}
