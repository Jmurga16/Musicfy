using Entities.Exceptions;
using Entities.POCOEntities;
using Entities.Interfaces;
using Repositories.EFCore.DataContext;
using UseCasesPorts.ListAlbum;

namespace UseCases.ListAlbum
{
    //Equivalente al Command Handler (CQRS)
    public class ListAlbumInteractor : IListAlbumInputPort
    {
        readonly IAlbumRepository AlbumRepository;
        readonly IListAlbumOutputPort OutputPort;
        readonly MusicfyContext Context;
        public ListAlbumInteractor(IAlbumRepository albumRepository, IListAlbumOutputPort outputPort, MusicfyContext context) =>
            (AlbumRepository, OutputPort, Context) = (albumRepository, outputPort, context);

        //Obtener Albums
        public async Task GetAlbums()
        {

            IEnumerable<Album> response;

            try
            {

                response = AlbumRepository.GetAlbums();

            }
            catch (Exception ex)
            {
                throw new GeneralException("Error al listar productos.", ex.Message);
            }

            await OutputPort.Handle(response);
        }

    }
}
