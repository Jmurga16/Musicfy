using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCasesDTOs.FormAlbum;

namespace UseCasesPorts.FormAlbum
{
    public interface ICreateAlbumOutputPort
    {
        Task Handle(int Id);
    }
}
