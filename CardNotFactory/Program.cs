using System;
using System.Net.Http.Headers;
using Factory.Models.OnlineStores;
using Factory.Scripts;
using Factory.Services.Payment;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup dependencies.
            ICardService cardService = new CardService();

            // Setup Business.
            ProcessCard processCard = new ProcessCard(cardService);

            // Run operations.
            ICard card = processCard.Process(5000);
        }
    }
}
