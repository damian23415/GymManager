using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Application.Tickets.Queries.GetTicketById;

public class GetTicketByIdQueryHandler : IRequestHandler<GetTicketByIdQuery, TicketDto>
{
    public async Task<TicketDto> Handle(GetTicketByIdQuery request, CancellationToken cancellationToken)
    {
        var id = request.Id;
        return new TicketDto { Id = id, Name = "Nazwa" };
    }
}
