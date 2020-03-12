using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Framework
{
    public class SavingAccount
    {
        public Guid Id { get; set; }
        public Double Amount { get; set; }
        public Double RateInterests { get; set; }            
    }
}
