using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace Reminder.modules
{
    public class Database
    {
        private readonly string _connectionString = "Data Source=database.db";
        public void createDatabase()
        {
            if (File.Exists("database.db")) return;
            using(var db = new SqliteConnection(_connectionString))
            {
                db.Open();
                var command = db.CreateCommand();
                command.CommandText = @"CREATE TABLE agenda(
                    title TEXT,
                    detail TEXT,
                    todotime DATE
                );";
                command.ExecuteNonQuery();
            }
        }
        public void addToDo(string date, string title, string detail)
        {
            using (var db = new SqliteConnection(_connectionString))
            {
                db.Open();
                var command = db.CreateCommand();
                command.CommandText = @"INSERT INTO agenda(title, detail, todotime)
                    VALUES($title, $detail, $todotime);";
                command.Parameters.AddWithValue("$title", title);
                command.Parameters.AddWithValue("$detail", detail);
                command.Parameters.AddWithValue("$todotime", date);
                command.ExecuteNonQuery();
            }
        }
        public string[] getDateTitle(string theDate)
        {
            List<string> result = new List<string>();

            var db = new SqliteConnection(_connectionString);
            
            db.Open();
            var command = db.CreateCommand();
            command.CommandText = @"SELECT title FROM agenda
                WHERE todotime = $date";
            command.Parameters.AddWithValue("$date", theDate);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                //string title = reader.GetString(0);
                //Console.WriteLine(title);
                result.Add(reader.GetString(0));
                //Console.WriteLine(reader.GetString(0));
            }
            reader.Close();
            db.Close();
            string[] todayTitle = result.ToArray();
            return todayTitle;
        }
        public string[] getTodayTitle()
        {
            List<string> result = new List<string>();
            
            var db = new SqliteConnection(_connectionString);
            
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            db.Open();
            var command = db.CreateCommand();
            command.CommandText = @"SELECT title FROM agenda
                WHERE todotime = $today";
            command.Parameters.AddWithValue("$today", today);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                //string title = reader.GetString(0);
                //Console.WriteLine(title);
                result.Add(reader.GetString(0));
                //Console.WriteLine(reader.GetString(0));
            }
            reader.Close();
            db.Close();
            string[] todayTitle = result.ToArray();
            return todayTitle;
        }
        public string getDateInfo(string title, string date)
        {
            var db = new SqliteConnection(_connectionString);
            string result = "";
            db.Open();
            var command = db.CreateCommand();
            command.CommandText = @"SELECT detail FROM agenda
                WHERE todotime = $date AND title = $title";
            command.Parameters.AddWithValue("$date", date);
            command.Parameters.AddWithValue("$title", title);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                result = reader.GetString(0);
            }
            reader.Close();
            db.Close();
            return result;
        }
        public void delToDo(string title, string date)
        {
            var db = new SqliteConnection(_connectionString);
            db.Open();
            var command = db.CreateCommand();
            command.CommandText = @"DELETE FROM agenda WHERE todotime = $date AND title = $title;";
            command.Parameters.AddWithValue("$date", date);
            command.Parameters.AddWithValue("$title", title);
            command.ExecuteNonQuery();
        }
    }
}
