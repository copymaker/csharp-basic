using System;
using System.Linq;
using RoadBook.CsharpBasic.Chapter08.Data;
using RoadBook.CsharpBasic.Chapter08.Model;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    public class Ex006
    {
        public void Run()
        {
            using (UserContext context = new UserContext())
            {
                IQueryable<User> queryable = context.Users.Select(u => u);

                foreach (var user in queryable)
                {
                    Console.WriteLine(user);
                }
                
            }
        }
    }
}