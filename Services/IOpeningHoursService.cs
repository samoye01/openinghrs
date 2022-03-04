using System;
using Accelerex.API.Models;

namespace Accelerex.API.Services
{
    public interface IOpeningHoursService
    {
        Response ProcessRequest(DayOfWeekto inputto);
    }
}
