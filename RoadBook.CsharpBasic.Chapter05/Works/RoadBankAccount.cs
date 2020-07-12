using System;

namespace RoadBook.CsharpBasic.Chapter05.Works
{
    public class RoadBankAccount
    {
        public string Name { get; }
        public string CustomerName { get; }

        public int Balance
        {
            get;
            private set;
        }

        public RoadBankAccount(string name, string customerName)
        {
            Name = name;
            CustomerName = customerName;
        }

        public bool PlusBalance(int amount)
        {
            Balance += amount;
            return true;
        }
        
        public bool MinusBalance(int amount)
        {
            if (amount > Balance)
            {
                return false;
            }
            
            Balance -= amount;
            return true;
        }
    }
}