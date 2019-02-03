using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asite.Models {
    public static class TimeIntervals {
        public static readonly double SECOND = TimeSpan.FromSeconds(1).TotalSeconds;
        public static readonly double MINUTE = TimeSpan.FromMinutes(1).TotalSeconds;
        public static readonly double HOUR = TimeSpan.FromDays(1).TotalSeconds;
        public static readonly double WEEK = TimeSpan.FromDays(7).TotalSeconds;
        public static readonly double YEAR = TimeSpan.FromDays(365).TotalSeconds;
    }
}
