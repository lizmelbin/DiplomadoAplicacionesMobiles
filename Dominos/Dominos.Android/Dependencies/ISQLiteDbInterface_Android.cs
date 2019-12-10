
using System;
using System.IO;
using Dominos.Interfaces;
using SQLite;
using Xamarin.Forms;
using static Dominos.Droid.ISQLiteDbInterface_Android;

[assembly: Dependency(typeof(GetSQLiteConnnection))]
namespace Dominos.Droid
{
    class ISQLiteDbInterface_Android
    {
        public class GetSQLiteConnnection : ISQLiteInterface
        {
            public GetSQLiteConnnection()
            {
            }
            public SQLite.SQLiteAsyncConnection GetSQLiteConnection()
            {
                var fileName = "Dominos.db3";
                var documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                var path = Path.Combine(documentPath, fileName);
               // var platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
                var connection = new SQLiteAsyncConnection( path);
                return  connection;
            }

            
        }
    }
}