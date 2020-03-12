using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Framework
{
    public class Person
    {
        public Guid PersonId { get; set; }
        public String Name { get; set; }

        public ICollection<SavingAccount> Savings { get; set; }
    }
}
