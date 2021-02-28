using System;
using System.Threading;
using Factory.Services.Payment;

namespace Factory.Models.OnlineStores
{
    public class SmartCard : ICard
    {
        private readonly ICardService _cardService;

        public string AnnualAmount { get; }

        public SmartCard(string annualAmount, ICardService cardService)
        {
            AnnualAmount = annualAmount;
            _cardService = cardService;
            Console.WriteLine($"Processing smartcard with amount {annualAmount} ");
        }
    }
}