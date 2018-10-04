using CrudResourceIT.Domain.Entities;
using FluentValidation;
namespace CrudResourceIT.Domain.Validators
{
	public class UserValidator : AbstractValidator<User>
	{
		public UserValidator()
		{
			RuleFor(x => x.FirstName).NotEmpty();
			RuleFor(x => x.FirstName).NotEmpty().WithMessage("Por favor informe o nome");
			RuleFor(x => x.FirstName).NotEmpty();
			RuleFor(x => x.FirstName).NotEmpty().WithMessage("Por favor informe o sobrenome");
			RuleFor(x => x.Email).NotEmpty();
			RuleFor(x => x.Email).NotEmpty().WithMessage("Por favor informe o email");
			RuleFor(x => x.Email).EmailAddress().WithMessage("Email não válido");
		}
	}
}