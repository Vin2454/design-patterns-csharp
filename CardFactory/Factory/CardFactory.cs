using Factory.Models;
using Factory.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Factory
{
    public class CardFactory : ICardFactory
    {

        private readonly ICardService _cardService;

        public CardFactory(ICardService cardService)
        {
            _cardService = cardService;
        }
        public ICard GetCard(decimal annualSalary)
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
