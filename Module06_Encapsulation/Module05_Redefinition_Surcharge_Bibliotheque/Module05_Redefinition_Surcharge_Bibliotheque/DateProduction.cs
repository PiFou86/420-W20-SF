using System;
using System.Collections.Generic;
using System.Text;

namespace Module05_Redefinition_Surcharge_Bibliotheque
{
    public class DateProduction
    {
        public static DateTime Now { get; private set; } = DateTime.Now;

        public static void AvancerDateProduction(int p_nombreJours = 1)
        {
            Now = Now.AddDays(p_nombreJours);
        }
    }
}
