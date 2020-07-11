using System;

namespace RoadBook.CsharpBasic.Chapter04.Works
{
    public class Exam003
    {
        public void Run()
        {
            Console.WriteLine("*********** 안녕하세요 Road Bank입니다 ***********");
            Console.WriteLine("1: 잔액조회");
            Console.WriteLine("2: 입금");
            Console.WriteLine("3: 출금");
            Console.WriteLine("0: 종료");
            Console.WriteLine("***********************************************");

            int balance = 0;

            while (true)
            {
                int inputCode = Convert.ToInt32(Console.ReadLine());

                if (inputCode == 0)
                {
                    break;
                }
                
                switch (inputCode)
                {
                    case 1:
                        Console.WriteLine("잔액은 '{0}'원입니다.", balance);
                        break;
                    case 2:
                        Console.WriteLine("입금할 금액을 입력하세요");
                        int depositAmount = Convert.ToInt32(Console.ReadLine());
                        balance += depositAmount;
                        Console.WriteLine("입금되었습니다.");
                        break;
                    case 3:
                        Console.WriteLine("출금할 금액을 입력하세요");
                        int withdrawAmount = Convert.ToInt32(Console.ReadLine());
                        if (withdrawAmount > balance)
                        {
                            Console.WriteLine("잔액이 부족합니다. (잔액: {0})", balance);
                        }
                        else
                        {
                            balance -= withdrawAmount;
                            Console.WriteLine("출금되었습니다.");
                        }
                        break;
                    default:
                        Console.WriteLine("0 ~ 3 사이의 값을 입력해주세요.");
                        break;
                }
            }
            
            Console.WriteLine("감사합니다.");
        }
    }
}