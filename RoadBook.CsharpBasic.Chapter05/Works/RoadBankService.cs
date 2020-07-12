using System;

namespace RoadBook.CsharpBasic.Chapter05.Works
{
    public class RoadBankService
    {
        private RoadBankAccount _account;

        public void CreateAccount(string name, string customerName)
        {
            if (_account != null)
            {
                Console.WriteLine("이미 계좌가 존재합니다.");
                return;
            }
            
            _account = new RoadBankAccount(name, customerName);
            Console.WriteLine("'{0}'님의 '{1}'이 개설되었습니다.", _account.CustomerName, _account.Name);
        }

        public void ReadAccount()
        {
            if (_account == null)
            {
                Console.WriteLine("계좌가 없습니다.");
                return;
            }

            Console.WriteLine("잔액은 '{0}'원입니다.", _account.Balance);
        }

        public void Deposit(int amount)
        {
            if (_account == null)
            {
                Console.WriteLine("계좌가 없습니다.");
                return;
            }

            _account.PlusBalance(amount);
            Console.WriteLine("입금되었습니다.");
        }

        public void Withdraw(int amount)
        {
            if (_account == null)
            {
                Console.WriteLine("계좌가 없습니다.");
                return;
            }

            Console.WriteLine(_account.MinusBalance(amount) ? "출급되었습니다." : "잔액이 부족합니다.");
        }
    }
}