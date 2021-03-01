using System;
using Factory.Factory;
using Factory.Models;
using Factory.Services;

namespace Factory.Business
{
    public class ProcessCard
    {
        private readonly ICardFactory _cardFactory;

        public ProcessCard(ICardFactory cardFactory)
        {
            _cardFactory = cardFactory;
        }

        public ICard Process(decimal annualSalary)
        {
            //string annualAmount = annualSalary.ToString();
            //ICard card;
            //if (annualSalary < 10000)
            //{
            //    card = new SmartCard(annualAmount, _cardService);
            //}
            //else
            //{
            //    card = new TravelCard(annualAmount, _cardService);
            //}
            //return card;
            return _cardFactory.GetCard(annualSalary);
        }
    }
}