using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCasesDTOs.FormAlbum;

namespace UseCasesPorts.FormAlbum
{
    public interface ICreateAlbumInputPort
    {
        Task Create(FormAlbumRequest request);
    }
}
