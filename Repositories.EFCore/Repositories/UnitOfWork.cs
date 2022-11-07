using Entities.Interfaces;
using Repositories.EFCore.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Repositories
{
    public class UnitOfWork: IUnitOfWork
    {
        readonly MusicfyContext Context;
        public UnitOfWork(MusicfyContext context) => Context = context;

        public Task<int> SaveChangesAsync()
        {
            return Context.SaveChangesAsync();
        }
    }
}
