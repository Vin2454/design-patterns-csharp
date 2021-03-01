using System;

namespace Factory.Services
{
    public class CardService : ICardService
    {
        public void ProcessCard(string name)
        {
            Console.WriteLine($"Processing for {name}.");
        }
    }
}