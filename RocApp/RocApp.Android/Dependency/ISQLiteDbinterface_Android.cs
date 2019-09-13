﻿using System.IO;
using RocApp.Droid;
using RocApp.Interfaces;
using SQLite;
using Xamarin.Forms;
[assembly: Dependency(typeof(ISQLiteDbInterface_Android))]

namespace RocApp.Droid
{
    public class ISQLiteDbInterface_Android : ISQLiteInterface
    {
        public ISQLiteDbInterface_Android() { }
        public SQLite.SQLiteConnection GetSQLiteConnection()
        {
            var fileName = "UserDatabase.db3";
            var documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, fileName);
            var connection = new SQLiteConnection(path);
            return connection;
        }
    }
}