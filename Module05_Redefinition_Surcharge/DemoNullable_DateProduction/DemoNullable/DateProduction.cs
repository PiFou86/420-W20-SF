﻿using System;

namespace DemoNullable;

public class DateProduction
{
    public static DateTime Now { get; private set; } = DateTime.Now;

    public static void AvancerTemps(int p_nombreJours)
    {
        Now = Now.AddDays(p_nombreJours);
    }
}
