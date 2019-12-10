using SQLite;



namespace Dominos.Interfaces
{
    public interface ISQLiteInterface
    {
        SQLiteAsyncConnection GetSQLiteConnection();
       
    }
}
