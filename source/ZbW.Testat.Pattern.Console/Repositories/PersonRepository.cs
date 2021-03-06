﻿namespace ZbW.Testat.Pattern.Console.Repositories
{
    using System;
    using System.Collections.Generic;

    using ZbW.Testat.Pattern.Console.Interfaces;
    using ZbW.Testat.Pattern.Console.Items;

    public class PersonRepository : IRepository
    {
        private readonly List<Person> _personItems;

        public PersonRepository()
        {
            _personItems = new List<Person>();
        }

        public void AddItem<T>(T item)
        {
            var person = item as Person;
            _personItems.Add(person);
            throw new NotImplementedException();
        }

        public void RemoveItem<T>(T item)
        {
            throw new NotImplementedException();
        }

        public List<T> GetItems<T>()
        {
            throw new NotImplementedException();
        }
    }
}