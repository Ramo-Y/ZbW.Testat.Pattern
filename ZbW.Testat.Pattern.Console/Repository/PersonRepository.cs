namespace ZbW.Testat.Pattern.Console.Repository
{
    using System;

    using ZbW.Testat.Pattern.Console.Interfaces;

    public class PersonRepository : IRepository
    {
        public void AddItem<T>(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveItem<T>(T item)
        {
            throw new NotImplementedException();
        }

        public T GetItems<T>()
        {
            throw new NotImplementedException();
        }
    }
}