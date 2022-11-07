using FluentValidation;


namespace UseCases.Common.Validators
{
    public class CreateAlbumValidator 
    {
        public CreateAlbumValidator()
        {

            //RuleFor(c => c.ShipAddress).NotEmpty()
            //        .WithMessage("Debe proporcionar la dirección de envío.");
            //
            //RuleFor(c => c.ShipCity).NotEmpty().MinimumLength(3)
            //        .WithMessage("Debe proporcionar al menos 3 caracteres del nombre de la ciudad.");
            //
            //RuleFor(c => c.ShipCountry).NotEmpty().MinimumLength(3)
            //       .WithMessage("Debe proporcionar al menos 3 caracteres del nombre del País.");
            //
            //RuleFor(c => c.OrderDetails)
            //        .Must(d => d != null && d.Any())
            //        .WithMessage("Deben especificarse los productos de la orden.");
        }
    }
}
