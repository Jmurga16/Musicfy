using Entities.Interfaces;
using FluentValidation;
using UseCases.Common.Validators;
using UseCasesDTOs.FormAlbum;
using UseCasesPorts.FormAlbum;
using Entities.POCOEntities;
using Entities.Exceptions;


namespace UseCases.FormAlbum
{
    public class DeleteAlbumInteractor : IDeleteAlbumInputPort
    {
        readonly IAlbumRepository AlbumRepository;
        readonly IUnitOfWork UnitOfWork;
        readonly IDeleteAlbumOutputPort OutputPort;

        public DeleteAlbumInteractor(IAlbumRepository albumRepository, IUnitOfWork unitOfWork, IDeleteAlbumOutputPort outputPort) =>
       (AlbumRepository, UnitOfWork, OutputPort) = (albumRepository, unitOfWork, outputPort);

        public async Task Delete(int Id)
        {
                        
            try
            {
                AlbumRepository.Delete(Id);               
            }
            catch (Exception ex)
            {
                throw new GeneralException("Error al eliminar el album.", ex.Message);
            }

            await OutputPort.Handle(Id);
        }

    }
}
