using System;
using System.Collections.Generic;
using System.Linq;
using Accelerex.API.Models;

namespace Accelerex.API.Services
{
    public class OpeningHoursService : IOpeningHoursService
    {
        public Response ProcessRequest(DayOfWeekto inputto)
        {
            try
            {
                var monday = ComputeForDay(inputto.Monday);
                var tuesday = ComputeForDay(inputto.Tuesday);
                var wednesday = ComputeForDay(inputto.Wednesday);
                var thurday = ComputeForDay(inputto.Thursday);
                var friday = ComputeForDay(inputto.Friday);
                var saturday = ComputeForDay(inputto.Saturday);
                var sunday = ComputeForDay(inputto.Sunday);

                var data = new List<string>();
                data.Add($"Monday: {monday}");
                data.Add($"Tuesday: {tuesday}");
                data.Add($"Wednesday: {wednesday}");
                data.Add($"Thurday: {thurday}");
                data.Add($"Friday: {friday}");
                data.Add($"Saturday: {saturday}");
                data.Add($"Sunday: {sunday}");

                return new Response
                {
                    IsSuccess = true,
                    Message = "Yay!!! we have some data",
                    Data = data
                };
            }
            catch (Exception)
            {
                throw;
            }
        }

        private string ComputeForDay(List<OpeningHoursto> openingHours)
        {
           var hours = string.Empty;
            var dateTime = DateTime.Now;
            var time = string.Empty;

            if (openingHours.Count == 0)
            {
                hours += "closed";
            }

            foreach (var item in openingHours)
            {
              
                if(item.Type.ToLower() == "open")
                {
                    dateTime = UnixTimeToDateTime(item.Value);

                    time = dateTime.ToShortTimeString();

                    hours += time;
                }
                else
                {
                    dateTime = UnixTimeToDateTime(item.Value);

                    time = dateTime.ToShortTimeString();

                    if(openingHours[0] == item)
                    {
                        hours += $"{time},";
                    }
                    else
                    {
                        hours += $" - {time},";
                    }

                }
               
            }

            return hours;
        }

        private DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddMilliseconds(unixtime).ToLocalTime();
            return dtDateTime;
        }
    }
}
