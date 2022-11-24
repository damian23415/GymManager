using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Application.Tickets.Commands.AddTicket;

public class AddTicketCommand : IRequest
{
    public string Name { get; set; }
}
