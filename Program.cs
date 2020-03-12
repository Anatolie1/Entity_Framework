using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Framework
{
    static class Program
    {

        static void Main()
        {    
            using (var context = new MyContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var person = new Person
                {
                    Name = "Richard"
                };

                person.Savings = new List<SavingAccount>
                {
                    new SavingAccount {Amount = 2000000, RateInterests = 0.05},
                    new SavingAccount {Amount = 250000, RateInterests = 0.15},
                    new SavingAccount {Amount = 10000000, RateInterests = 0.02}
                };
                context.Add(person);
                context.SaveChanges();

                DateTime begin = DateTime.Now - TimeSpan.FromDays(1094);
                DateTime end = DateTime.Now;

                SavingCalculator savings = new SavingCalculator();
                double amountsavings = savings.CalculateTotalSaved(begin, end);

                MessageBox.Show(amountsavings.ToString(), "Saving Money",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
