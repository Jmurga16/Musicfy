using Entities.POCOEntities;


namespace Entities.Interfaces
{
    public interface IAlbumRepository
    {
        void Create(Album album);
        IEnumerable<Album> GetAlbums();
        int RowCount();
        void Update(Album album);   
        void Delete(int Id);
    }
}
