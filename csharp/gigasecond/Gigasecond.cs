using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        TimeSpan gigasecond = new TimeSpan(0, 0, 1000000000);
        return moment.Add(gigasecond);
    }
}