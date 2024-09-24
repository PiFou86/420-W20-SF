using System;

namespace DemoNullable;

class Program
{
    static void Main(string[] args)
    {
        DateTime dateTime = DateProduction.Now;

        DateProduction.AvancerTemps(3);
        dateTime = DateProduction.Now;
    }
}
