using System;
using System.Diagnostics.CodeAnalysis;
using Weather.API.Interfaces;

namespace Weather.API.Services
{
    [ExcludeFromCodeCoverage]
    public class DateService : IDateService
    {
        public DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }
    }
}