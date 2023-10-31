using System;

namespace P3.ShoppingSpree;

public class Product
{
    private string name;
    private decimal cost;

    public Product(string name, decimal cost)
    {
        Name = name;
        Cost = cost;
    }

    public string Name
    {
        get => name;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(ExceptionMessages.NameEmpty);
            }

            name = value;
        }
    }

    public decimal Cost
    {
        get => cost;
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException(ExceptionMessages.MoneyNegative);
            }

            cost = value;
        }
    }
}