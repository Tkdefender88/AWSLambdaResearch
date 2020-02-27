using System.Collections.Generic;
using RestAPI.Models;

namespace RestAPI.Services
{
    public class GreetingService : IGreetingService
    {
        private readonly Dictionary<string, int> _greetingStorage = new Dictionary<string, int>();
        public Dictionary<string, int> GetGreetings()
        {
            return _greetingStorage;
        }

        public void AddGreetings(GreetingsListModel greetingsList)
        {
            _greetingStorage.Add(greetingsList.Name, greetingsList.Age);
        }

        public void RemoveItem(string greetingsListName)
        {
            _greetingStorage.Remove(greetingsListName);
        }
    }
}