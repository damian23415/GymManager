using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Application.Common.Interfaces;

public interface IEmail
{
    Task Update(IAppSettingsService appSettingsService);
    Task SendAsync(string subject, string body, string to, string attachmentPath = null);
}
