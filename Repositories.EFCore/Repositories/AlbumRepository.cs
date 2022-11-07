using Entities.Interfaces;
using Entities.POCOEntities;
using Repositories.EFCore.DataContext;


namespace Repositories.EFCore.Repositories
{
    public class AlbumRepository : IAlbumRepository
    {
        readonly MusicfyContext Context;
        public AlbumRepository(MusicfyContext context) => Context = context;

        //Crear
        public void Create(Album album)
        {
            Context.Add(album);
        }

        //Listar Todo
        public IEnumerable<Album> GetAlbums()
        {
            return Context.Albums.ToList();
        }

        //Actualizar
        public void Update(Album album)
        {
            Context.Update(album);
        }

        //Eliminado Lógico
        public void Delete(Album album)
        {
            Context.Albums
                .Where(p => p.Id == album.Id)
                .ToList()
                .ForEach(x => x.Status = album.Status);
        }

    }
}
