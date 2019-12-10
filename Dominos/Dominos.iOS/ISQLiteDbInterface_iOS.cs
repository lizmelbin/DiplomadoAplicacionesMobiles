using Dominos.Interfaces;
using SQLite;
using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(Dominos.iOS.ISQLiteDbInterface_iOS))]
namespace Dominos.iOS
{
    public class ISQLiteDbInterface_iOS : ISQLiteInterface
    {
        public SQLiteAsyncConnection GetSQLiteConnection()
        {
            var fileName = "Dominos.db3";
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentsPath, "..", "Library");
            var path = Path.Combine(libraryPath, fileName);
//            var platform = new SQLite.Platform.XamarinIOS.SQLitePlatformIOS();
            var connection = new SQLiteAsyncConnection( path);
            return connection;
        }

         
    }
}