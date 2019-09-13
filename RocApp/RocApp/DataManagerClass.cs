using System.Collections.Generic;
using SQLite;
using Xamarin.Forms;
using RocApp.Interfaces;
using RocApp.Database;

namespace RocApp
{
    public class DataManagerClass
    {
        static object locker = new object();
        SQLiteConnection database;
        public DataManagerClass()
        {
            database = DependencyService.Get<ISQLiteInterface>().GetSQLiteConnection();
            database.CreateTable<UserProperties>();
        }

        public List<UserProperties> GetProperties()
        {
            List<UserProperties> Data = new List<UserProperties>();
            Data = database.Table<UserProperties>().ToList();
            return Data;
        }

        public void SaveDataOnDatabase(string Fullname, string Username, string Password, string Mood1, string Mood2, string Mood3, string Mood4, string Mood5
            , string Mood6, string Mood7, string Mood8)
        {
            UserProperties data = new UserProperties();
            data.CVProperties(Fullname, Username, Password, Mood1, Mood2, Mood3, Mood4, Mood5, Mood6, Mood7, Mood8);
            lock (locker)
            {
                database.Insert(data);
            }
        }
    }
}
