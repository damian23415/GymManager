using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Application.Contacts.Command;

public class SendContactEmailCommand : IRequest
{
    [Required(ErrorMessage = "Pole imie i nazwisko jest wymagane.")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Pole email jest wymagane.")]
    [EmailAddress(ErrorMessage = "Pole adres e-mail nie jest prawidłowym adresem e-mail")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Pole tytuł jest wymagane.")]
    public string Title { get; set; }
    [Required(ErrorMessage = "Pole wiadomość jest wymagane.")]
    public string Message { get; set; }
}
