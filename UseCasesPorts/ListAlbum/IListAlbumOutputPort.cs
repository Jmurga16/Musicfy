
using Entities.POCOEntities;

namespace UseCasesPorts.ListAlbum
{
    public interface IListAlbumOutputPort
    {
        Task Handle(IEnumerable<Album> Inventory);
        
    }
}
