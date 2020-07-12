using System;
using NUnit.Framework;
using RoadBook.CsharpBasic.Chapter05.Examples.Model;
using RoadBook.CsharpBasic.Chapter05.Examples.Service;

namespace RoadBook.CsharpBasic.Test.Chapter05
{
    [TestFixture]
    public class BoardTests
    {
        [Test]
        public void RuntTest()
        {
            // 기본 생성자 이용
            int number = 1;
            string title = "첫 번째 게시글입니다.";
            string content = "첫 번째 공지사항입니다.";
            string writer = "운영자";
            
            BoardService boardService = new BoardService();
            boardService.Save(number, title, content, writer);
            boardService.Read();
            
            Console.WriteLine("=====");
            title = "첫 번째 게시글 수정!!";
            boardService.Update(title, content, writer);
            boardService.Read();
            
            Console.WriteLine("=====");
            boardService.Delete();
            boardService.Read();
            
            Console.WriteLine("=====");
            
            // 생성자 오버로딩 이용
            Board board = new Board();
            board.Number = 2;
            board.Title = "두 번째 게시글입니다.";
            board.Content = "두 번째 공지사항입니다.";
            board.Writer = "운영자";
            board.CreateDate = DateTime.Now;
            board.UpdateDate = DateTime.Now;
            
            BoardService anotherBoardService = new BoardService(board);
            anotherBoardService.Read();
        }
    }
}