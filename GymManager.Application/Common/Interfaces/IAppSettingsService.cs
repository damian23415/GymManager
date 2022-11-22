namespace GymManager.Application.Common.Interfaces;

public interface IAppSettingsService
{
    Task Update(IApplicationDbContext context);
    Task<string> Get(string key);
}


