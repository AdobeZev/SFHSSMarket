using System;

using Scraper;

namespace Stocks
{
    class Stock
    {
        // Variables
        int _currentValue;

        // getter setter
        public int CurrentValue {get;}

        // Variables
        public void changeCurrentValue(int newValue)
        {
            _currentValue = newValue;
        }

        // Initializer
        public Stock(int newValue)
        {
            _currentValue = newValue;
        }
    }
}