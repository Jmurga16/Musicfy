using Entities.POCOEntities;
using UseCasesPorts.ListAlbum;

namespace Presenters.ListAlbum
{
    public class ListAlbumPresenter : IListAlbumOutputPort, IPresenter<IEnumerable<Album>>
    {
        public IEnumerable<Album> Content { get; private set; }

        public Task Handle(IEnumerable<Album> Albums)
        {
            Content = Albums;
            return Task.CompletedTask;
        }
    }
}
