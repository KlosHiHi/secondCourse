namespace DBLibrary
{
    public interface IDataBase
    {
        int ExecuteQuery(string query);

        bool UpdateGame(int id, string newTitle, double newPrice);
    }
}
