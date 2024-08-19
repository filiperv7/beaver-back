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
    public class OptionRepository : IOptionRepository
    {
        protected readonly AppDbContext Context;

        public OptionRepository(AppDbContext context)
        {
            Context = context;
        }

        public async Task<List<Option>> Get(int idInput, CancellationToken cancellationToken)
        {
            return await Context.Options.Where(x => x.Input.Id == idInput).ToListAsync(cancellationToken);
        }

        public void Create(Option entity)
        {
            Context.Add(entity);
        }

        public void Update(Option entity)
        {
            Context.Update(entity);
        }

        public void Delete(Option entity)
        {
            Context.Remove(entity);
        }
    }
}
