using System;
namespace Exercises
{
    public class Exercise004
    {
        const double GIGA_SECONDS = 1e9;
        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            return dateTime.AddSeconds(GIGA_SECONDS);
        }
    }
}
