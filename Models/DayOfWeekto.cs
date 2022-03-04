using System;
using System.Collections.Generic;

namespace Accelerex.API.Models
{
    public class DayOfWeekto
    {
        public List<OpeningHoursto>? Monday { get; set; }
        public List<OpeningHoursto>? Tuesday { get; set; }
        public List<OpeningHoursto>? Wednesday { get; set; }
        public List<OpeningHoursto>? Thursday { get; set; }
        public List<OpeningHoursto>? Friday { get; set; }
        public List<OpeningHoursto>? Saturday { get; set; }
        public List<OpeningHoursto>? Sunday { get; set; }
    }
}
