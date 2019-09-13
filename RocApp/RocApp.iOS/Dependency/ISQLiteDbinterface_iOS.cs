using System;
using Xamarin.Forms;
using System.IO;
using RocApp.Interfaces;
using SQLite;
using RocApp.iOS;

[assembly: Dependency(typeof(ISQLiteDbInterface_iOS))]
namespace RocApp.iOS
{
    public class ISQLiteDbInterface_iOS : ISQLiteInterface
    {
        public ISQLiteDbInterface_iOS() { }
        public SQLite.SQLiteConnection GetSQLiteConnection()
        {
            var fileName = "RocApp.db3";
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentsPath, "..", "Library");
            var path = Path.Combine(libraryPath, fileName);
            var connection = new SQLite.SQLiteConnection(path);
            return connection;
        }
    }
}