using Entities.Interfaces;
using Entities.POCOEntities;
using Microsoft.EntityFrameworkCore;
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

        //Listar (Estado Activo)
        public IEnumerable<Album> GetAlbums()
        {
            return Context.Albums.Where(c => c.Status == true).ToList();
        }

        //Numero de albumes creados
        public int RowCount()
        {
            return Context.Albums.Where(c => c.Status == true).Count();
        }

        //Actualizar
        public void Update(Album album)
        {
            Context.Update(album);

        }

        //Eliminado Lógico
        public void Delete(int id)
        {
            Album album1 = Context.Albums.Find(id);
            Context.Albums.Attach(album1);
            album1.Status = false;
            Context.Entry(album1).Property(x => x.Status).IsModified = true;
            Context.SaveChanges();
        }

    }
}
