//Documentacao com os validators existentes
//https://docs.fluentvalidation.net/en/latest/built-in-validators.html

using FluentValidation;
using MnemosyneAPI.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MnemosyneAPI.Validators
{
    public class MemoryValidator : AbstractValidator<Memory>
    {
        //metodo construtor tem o mesmo nome da classe
        public MemoryValidator()
        {
            RuleFor(x => x.Title)
                //Nao pode ser nulo
                .NotNull().WithMessage("O Titulo eh obrigatorio")
                .Length(3, 100).WithMessage("O Titulo deve ter no minimo 3 e no máximo 100 caracteres");

            RuleFor(x => x.Description)
                 //Nao pode ser nulo
                 .NotNull().WithMessage("A Descricao eh obrigatoria")
                 //Nao pode ser vazio
                 .NotEmpty().WithMessage("A Descricao nao pode ser vazia");

            RuleFor(x => x.Images)
                 //Nao pode ser nulo
                 .NotNull().WithMessage("A Imagem eh obrigatoria")
                 //Nao pode ser vazio
                 .NotEmpty().WithMessage("A Imagem nao pode ser vazia");

            //RuleFor(x => x.Date)
                //.NotEmpty().WithMessage("Informe a Data da memoria")
                //.MinimumLength(8).WithMessage("A data deve ter 8 caracteres");

    //Deve ser gerado no construtor(Data de Cadastro)


    }
    }
}

