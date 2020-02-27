using System.Collections.Generic;
using RestAPI.Models;

namespace RestAPI.Services
{
    public interface IGreetingService
    {
        Dictionary<string, int> GetGreetings();
        void AddGreetings(GreetingsListModel greetingsList);
        void RemoveItem(string greetingsListName);
    }
}