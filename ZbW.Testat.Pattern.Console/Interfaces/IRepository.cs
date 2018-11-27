namespace ZbW.Testat.Pattern.Console.Interfaces
{
    public interface IRepository
    {
        void AddItem<T>(T item);

        void RemoveItem<T>(T item);

        T GetItems<T>();
    }
}