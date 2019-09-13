using System.IO;
using RocApp.UWP;
using RocApp.Interfaces;
using SQLite;
using Xamarin.Forms;
[assembly: Dependency(typeof(ISQLiteDbInterface_UWP))]

namespace RocApp.UWP
{
    public class ISQLiteDbInterface_UWP : ISQLiteInterface
    {
        string localFolder = Windows.Storage.ApplicationData.Current.LocalFolder.Path;

        public ISQLiteDbInterface_UWP() { }
        public SQLite.SQLiteConnection GetSQLiteConnection()
        {
            var fileName = "UserDatabase.db3";
            var path = Path.Combine(localFolder, fileName);
            var connection = new SQLiteConnection(path);
            return connection;
        }
    }
}