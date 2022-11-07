using Entities.POCOEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCasesDTOs.FormAlbum;

namespace Entities.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();
        void UpdateChangesAsync(Album request);
        void DeleteChangesAsync(Album request);
    }
}
