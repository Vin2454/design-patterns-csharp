using System;
using Factory.Models.OnlineStores;
using Factory.Services.Payment;

namespace Factory.Scripts
{
    public class ProcessCard
    {
        private readonly ICardService _cardService;

        public ProcessCard(ICardService cardService)
        {
            _cardService = cardService;
        }

        public ICard Process(decimal annualSalary)
        {
            string annualAmount = annualSalary.ToString();
            ICard card;
            if (annualSalary < 10000)
            {
                card = new SmartCard(annualAmount, _cardService);
            }
            else
            {
                card = new TravelCard(annualAmount, _cardService);
            }
            return card;
        }
    }
}