using System;
using RoadBook.CsharpBasic.Chapter05.Examples.Model;

namespace RoadBook.CsharpBasic.Chapter05.Examples.Service
{
    public class BoardService
    {
        private Board _board;

        public BoardService()
        {
            _board = new Board();
        }

        public BoardService(Board board)
        {
            this._board = board;
        }

        public void Save(int number, string title, string content, string writer)
        {
            _board.Number = number;
            _board.Title = title;
            _board.Content = content;
            _board.Writer = writer;
            _board.CreateDate = DateTime.Now;
            _board.UpdateDate = DateTime.Now;
            
            Console.WriteLine("게시물이 저장되었습니다.");
        }

        public void Update(string title, string content, string writer)
        {
            _board.Title = title;
            _board.Content = content;
            _board.Writer = writer;
            _board.UpdateDate = DateTime.Now;
            
            Console.WriteLine("게시물이 수정되었습니다.");
        }

        public void Delete()
        {
            _board = null;
            
            Console.WriteLine("게시물이 삭제되었습니다.");
        }

        public void Read()
        {
            if (_board != null)
            {
                Console.WriteLine("{0}번 게시물", _board.Number);
                Console.WriteLine("제목 : {0}", _board.Title);
                Console.WriteLine("작성일 : {0}", _board.CreateDate);
                Console.WriteLine("수정일 : {0}", _board.UpdateDate);
                Console.WriteLine("글쓴이 : {0}", _board.Writer);
                Console.WriteLine("내용 : {0}", _board.Content);
            }
            else
            {
                Console.WriteLine("게시물이 없습니다.");
            }
        }
    }
}