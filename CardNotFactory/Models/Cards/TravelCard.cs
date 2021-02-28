using System;
using System.Threading;
using Factory.Services.Payment;

namespace Factory.Models.OnlineStores
{
    public class TravelCard : ICard
    {
        private readonly ICardService _cardService;

        public string AnnualAmount { get; }

        public TravelCard(string annualAmount, ICardService cardService)
        {
            AnnualAmount = annualAmount;
            _cardService = cardService;
            Console.WriteLine($"Processing travelcard with amount {annualAmount} ");
        }
    }
}