using Entities.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Common.Validators;
using UseCasesDTOs.FormAlbum;
using UseCasesPorts.FormAlbum;
using Entities.POCOEntities;
using Entities.Exceptions;

namespace UseCases.FormAlbum
{
    public class UpdateAlbumInteractor : IUpdateAlbumInputPort
    {
        readonly IAlbumRepository AlbumRepository;
        readonly IUnitOfWork UnitOfWork;
        readonly IUpdateAlbumOutputPort OutputPort;
        readonly IEnumerable<IValidator<FormAlbumRequest>> Validators;

        public UpdateAlbumInteractor(IAlbumRepository albumRepository, IUnitOfWork unitOfWork,
            IUpdateAlbumOutputPort outputPort, IEnumerable<IValidator<FormAlbumRequest>> validators) =>
       (AlbumRepository, UnitOfWork, OutputPort, Validators) = (albumRepository, unitOfWork, outputPort, validators);

        public async Task Update(FormAlbumRequest album)
        {
            await Validator<FormAlbumRequest>.Validate(album, Validators);

            Album Album = new Album()
            {
                Id = album.Id,
                Name = album.Name,
                Artist = album.Artist,
                Year = album.Year,
                ImageURL = album.ImageURL,
                Status = true,
            };
            AlbumRepository.Update(Album);

            try
            {
                await UnitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new GeneralException("Error al actualizar el album.", ex.Message);
            }

            await OutputPort.Handle(Album.Id);
        }
    }
}
