using NUnit.Framework;
using RoadBook.CsharpBasic.Chapter05.Works;

namespace RoadBook.CsharpBasic.Test.Chapter05
{
    [TestFixture]
    public class RoadBankTests
    {
        [Test]
        public void RunTest()
        {
            RoadBankService roadBankService = new RoadBankService();
            
            // 사용자 계좌 개설
            roadBankService.CreateAccount("로드은행통장", "로드북");
            
            // 입금
            roadBankService.Deposit(20000);
            
            // 잔액 조회
            roadBankService.ReadAccount();
            
            // 출금
            roadBankService.Withdraw(15000);
            
            // 잔액 조회
            roadBankService.ReadAccount();
            
            // 출금 (잔액 부족)
            roadBankService.Withdraw(100000);
        }
    }
}