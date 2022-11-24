using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Application.Tickets.Queries.GetTicketById;

public class GetTicketByIdQuery : IRequest<TicketDto>
{
    public int Id { get; set; }
}
