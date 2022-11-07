using Entities.POCOEntities;


namespace Entities.Interfaces
{
    public interface IAlbumRepository
    {
        void Create(Album album);
        IEnumerable<Album> GetAlbums();
        void Update(Album album);   
        void Delete(Album album);
    }
}
