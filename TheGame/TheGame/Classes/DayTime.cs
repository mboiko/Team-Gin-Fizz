using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheGame.Classes
{
    public static class DayTime
    {
        public static DateTime Dt { get; set; }


        public static string PrintTime()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Dt.Hour);
            builder.Append(":");
            builder.Append(Dt.Minute);
            builder.Append("  ");
            builder.Append(Dt.Day);
            builder.Append("." + Dt.Month);
            builder.Append("." + Dt.Year);
            return builder.ToString();

        }

        public static void SetTime(DateTime time)
        {
            Dt = time;
        }

    }
}
