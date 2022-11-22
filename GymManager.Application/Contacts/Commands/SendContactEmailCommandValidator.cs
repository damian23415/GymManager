using FluentValidation;
using GymManager.Application.Contacts.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Application.Contacts.Commands;

public class SendContactEmailCommandValidator : AbstractValidator<SendContactEmailCommand>
{
    public SendContactEmailCommandValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Pole imie i nazwisko jest wymagane");
    }
}
