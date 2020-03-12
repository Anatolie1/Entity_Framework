using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Entity_Framework
{
    public class SavingCalculator
    {
        public Double CalculateTotalSaved(DateTime begin, DateTime end)
        {
            using (var context = new MyContext())
            {
                int day = (end - begin).Days;
                int year = day / 365;

                if ( year >= 1)
                {
                    return context.Savings.Select(x => x.Amount * Math.Pow(1 + x.RateInterests, year)).Sum();
                }
                else
                {
                    return context.Savings.Select(x => x.Amount).Sum();
                }
            }
        }
    }
}