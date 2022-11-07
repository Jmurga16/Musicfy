using Entities.Interfaces;
using FluentValidation;
using UseCases.Common.Validators;
using UseCasesDTOs.FormAlbum;
using UseCasesPorts.FormAlbum;
using Entities.POCOEntities;
using Entities.Exceptions;

namespace UseCases.FormAlbum
{
    public class CreateAlbumInteractor : ICreateAlbumInputPort
    {
        readonly IAlbumRepository AlbumRepository;
        readonly IUnitOfWork UnitOfWork;
        readonly ICreateAlbumOutputPort OutputPort;
        readonly IEnumerable<IValidator<FormAlbumRequest>> Validators;

        public CreateAlbumInteractor(IAlbumRepository albumRepository, IUnitOfWork unitOfWork,
            ICreateAlbumOutputPort outputPort, IEnumerable<IValidator<FormAlbumRequest>> validators) =>
       (AlbumRepository, UnitOfWork, OutputPort, Validators) = (albumRepository, unitOfWork, outputPort, validators);

        public async Task Create(FormAlbumRequest album)
        {
            //Validación de Campos            
            await Validator<FormAlbumRequest>.Validate(album, Validators);
            Album Album;

            try
            {
                //Validacion de Albums Máximos
                if (AlbumRepository.RowCount() >= 20)
                {
                    throw new GeneralException("No se pueden registrar más de 20 albums.");
                }

                Album = new Album()
                {
                    Name = album.Name,
                    Artist = album.Artist,
                    Year = album.Year,
                    ImageURL = album.ImageURL,
                    Status = true,
                };
                AlbumRepository.Create(Album);

                await UnitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new GeneralException("Error al crear el album.", ex.Message);
            }

            await OutputPort.Handle(Album.Id);
        }
    }
}
