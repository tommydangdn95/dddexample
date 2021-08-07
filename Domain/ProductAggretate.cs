using System;
using System.Collections.Generic;

namespace Domain
{
    // invarient , modifier, Aggretate root --> Root tong hop ( Entity, Value Object)
    public class ProductAggretate
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public Money Price { get; private set; }

        public List<Varient> varient { get; private set; }

        public ProductAggretate(Guid id, string name, decimal price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = new Money(price);
        }

        public void UpdateName(string name)
        {
            this.Name = name;
        }

        public void UpdatePrice(decimal amount)
        {
            this.Price = new Money(amount);
        }


        public void TransformNameUppercase()
        {
            this.Name = this.Name.ToUpper();
        }
    }
}
