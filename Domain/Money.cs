using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Money
    {
        public decimal Amount { get; private set; }
        public string Concurrency { get; private set; }

        public Money(decimal amount, string concurency = "SGD")
        {
            this.Amount = amount;
            this.Concurrency = concurency;
        }


        public static Money operator -(Money left, Money right)
        {
            return new Money(left.Amount - right.Amount);
        }


        public static Money operator +(Money left, Money right)
        {
            return new Money(left.Amount + right.Amount);
        }
    }
}
