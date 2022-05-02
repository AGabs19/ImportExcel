using ImportExcel.Models;
using FluentValidation;

namespace ImportExcel.Validator
{
    public class ExcelModelValidator : AbstractValidator<ExcelModel>
    {
        public ExcelModelValidator()
        {
            RuleFor(x => x.Nome)
                .NotNull().WithMessage("Por favor digite seu Nome")
                .Length(1, 50).WithMessage("Por Favor digite um nome valido");

            RuleFor(x => x.Sobrenome)
                .NotNull().WithMessage("Por Favor digite seu Sobrenome")
                .Length(5, 255).WithMessage("Por Favor se atente ao tamanho, numero de caracteres inavalido!");

            RuleFor(x => x.CPF.ToString())
                .NotNull().WithMessage("Por Favor digite seu CPF")
                .NotEmpty().WithMessage("Por favor digite seu CPF")
                .Length(11).WithMessage("Por Favor digite um CPF valido");

            RuleFor(x => x.Numero.ToString())
                .NotNull().WithMessage("Por Favor digite seu DDD e seu numero")
                .NotEmpty().WithMessage("Por Favor digite seu DDD e seu numero ")
                .Length(11).WithMessage("Por Favor digite um numero valido, se atente ao DDD");

            RuleFor(x => x.Descricao)
                .NotNull().WithMessage("Por Favor digite os campos corretamente")
                .NotEmpty().WithMessage("Por favor digite uma descricao")
                .Length(15, 255).WithMessage("Por Favor se atente ao tamanho, numero de caracteres invalidos!");

            RuleFor(x => x.Longadouro)
                .NotNull().WithMessage("Por Favor digite seu endereco")
                .NotEmpty().WithMessage("Por Favor certifique-se que os campos estão corretos")
                .Length(15, 255).WithMessage("Por Favor se atente ao tamanho, numero de caracteres invalidos!");

            RuleFor(x => x.NumeroCasa.ToString())
               .NotNull().WithMessage("Por Favor digite os campos corretamente")
               .NotEmpty().WithMessage("Por favor digite seu o numero correto")
               .Length(3).WithMessage("Por Favor se atente ao tamanho, numero de caracteres invalidos!");

            RuleFor(x => x.CEP.ToString())
               .NotNull().WithMessage("Por Favor digite os campos corretamente")
               .NotEmpty().WithMessage("Por favor digite seu CEP")
               .Length(8).WithMessage("Por Favor se atente ao tamanho, numero de caracteres invalidos!");

            RuleFor(x => x.Complemento)
               .NotNull().WithMessage("Por Favor digite os campos corretamente")
               .NotEmpty().WithMessage("Por favor digite um complemento")
               .Length(15, 255).WithMessage("Por Favor se atente ao tamanho, numero de caracteres invalidos!");

            RuleFor(x => x.Cargo)
               .NotNull().WithMessage("Por Favor digite os campos corretamente")
               .NotEmpty().WithMessage("Por favor digite seu Cargo")
               .Length(5, 64).WithMessage("Por Favor se atente ao tamanho, numero de caracteres invalidos!");
        }
    }
}