using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Application.Common.Behaviors;

public class LoggingBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
    private readonly ILogger<TRequest> _logger;
    public LoggingBehaviour(ILogger<TRequest> logger)
    {
        _logger = logger;
    }

    public ILogger<TRequest> Logger { get; }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        var requestName = typeof(TRequest).Name;
        _logger.LogInformation($"Handling {requestName}");
        _logger.LogInformation($"GymManager Request: {requestName} {request}");

        var response = await next();

        _logger.LogInformation($"Handled {typeof(TResponse).Name}");

        return response;
    }
}
