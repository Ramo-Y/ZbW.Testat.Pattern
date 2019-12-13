namespace ZbW.Testat.Pattern.Console.Interfaces
{
    using System.Collections.Generic;

    public interface IRepository
    {
        void AddItem<T>(T item);

        void RemoveItem<T>(T item);

        List<T> GetItems<T>();
    }
}