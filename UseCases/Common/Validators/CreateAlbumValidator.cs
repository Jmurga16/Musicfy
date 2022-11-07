using FluentValidation;
using UseCasesDTOs.FormAlbum;

namespace UseCases.Common.Validators
{
    public class CreateAlbumValidator : AbstractValidator<FormAlbumRequest>
    {
        public CreateAlbumValidator()
        {
          
            RuleFor(c => c.Name).NotEmpty()
                    .WithMessage("Debe proporcionar un Nombre de Album.");
            
            RuleFor(c => c.Artist).NotEmpty()
                    .WithMessage("Debe proporcionar el Nombre del Artista.");
            
            RuleFor(c => c.ImageURL).NotEmpty()
                   .WithMessage("Debe proporcionar un link de imagen.");
            
            RuleFor(c => c.Year).GreaterThan(2010).LessThan(2021)                    
                    .WithMessage("El año debe estar comprendido entre 2010 y 2021.");
        }
    }
}
