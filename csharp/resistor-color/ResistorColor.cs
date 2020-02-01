﻿using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        color = color.ToLower();
        return Array.IndexOf(Colors(), color);
    }

    public static string[] Colors()
    {
        string[] colors =
        {
            "black",
            "brown",
            "red",
            "orange",
            "yellow",
            "green",
            "blue",
            "violet",
            "grey",
            "white",
        };
        return colors;
    }
}