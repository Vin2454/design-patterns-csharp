using System;
using System.Net.Http.Headers;
using Factory.Business;
using Factory.Factory;
using Factory.Models;
using Factory.Services;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup dependencies.
            ICardService cardService = new CardService();
            ICardFactory cardFactory = new CardFactory(cardService);

            // Setup Business.
            ProcessCard processCard = new ProcessCard(cardFactory);

            // Run operations.
            ICard card = processCard.Process(5000);
        }
    }
}
