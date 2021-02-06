using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hirelonghorn.Utilities
{
    public static class Time
    {
        private static DateTime _systemTime;

        public static DateTime SystemTime
        {
            get { return _systemTime; }
            set { _systemTime = value; }
        }
    }
}
