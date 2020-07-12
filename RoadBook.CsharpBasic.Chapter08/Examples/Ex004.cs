using System.Data.SQLite;
using RoadBook.CsharpBasic.Chapter08.Model;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    public class Ex004
    {
        public void Run()
        {
            string connectionString = @"Data Source=test.db;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                User user = new User
                {
                    Id = "U006", 
                    Name = "유저", 
                    Age = 30, 
                    Job = "카운셀러"
                };

                string insertSql =
                    $"INSERT INTO USERS(ID, NAME, AGE, JOB) VALUES('{user.Id}', '{user.Name}', '{user.Age}', '{user.Job}')";
                
                using (SQLiteCommand command = new SQLiteCommand(insertSql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}