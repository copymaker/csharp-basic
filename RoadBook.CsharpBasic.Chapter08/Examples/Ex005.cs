using System;
using System.Data.SQLite;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    public class Ex005
    {
        public void Run()
        {
            string selectSQL = "SELECT ID, NAME, AGE, JOB FROM USERS";
            
            string connectionString = @"Data Source=test.db;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(selectSQL, connection))
                {
                    SQLiteDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine($"회원ID : {reader["ID"]}");
                        Console.WriteLine($"회원이름 : {reader["NAME"]}");
                        Console.WriteLine($"회원나이 : {reader["AGE"]}");
                        Console.WriteLine($"회원직업 : {reader["JOB"]}");
                        Console.WriteLine("=======");
                    }
                }
            }
        }
    }
}