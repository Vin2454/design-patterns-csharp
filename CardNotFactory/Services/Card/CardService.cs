using System;

namespace Factory.Services.Payment
{
    public class CardService : ICardService
    {
        public void ProcessCard(string name)
        {
            Console.WriteLine($"Processing for {name}.");
        }
    }
}