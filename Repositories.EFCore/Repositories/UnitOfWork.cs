using Entities.Interfaces;
using Entities.POCOEntities;
using Repositories.EFCore.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCasesDTOs.FormAlbum;

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

        public void UpdateChangesAsync(Album request)
        {
            Context.Albums.Update(request);
        }

        public void DeleteChangesAsync(Album request)
        {
            Context.Albums.Update(request);
        }

    }
}
