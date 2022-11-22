using GymManager.Application.Common.Interfaces;
using GymManager.Application.Dictionaries;
using MediatR;

namespace GymManager.Application.Contacts.Command;

public class SendContactEmailCommandHandler : IRequestHandler<SendContactEmailCommand>
{
    private readonly IEmail _email;
    private readonly IAppSettingsService _appSettingsService;

    public SendContactEmailCommandHandler(IEmail email, IAppSettingsService appSettings)
    {
        _email = email;
        _appSettingsService = appSettings;
    }

    public async Task<Unit> Handle(SendContactEmailCommand request, CancellationToken cancellationToken)
    {
        var body = $"Nazwa: {request.Name}.<br /><br />E-mail nadawcy: {request.Email}<br /><br />Tytuł wiadomości: {request.Title}<br /><br />Wiadomość: {request.Message}<br /><br />Wysłano z: GymManager";

        await _email.SendAsync($"Wiadomość z GymManager {request.Title}", body, await _appSettingsService.Get(SettingsDict.AdminEmail));

        return Unit.Value;
    }
}
