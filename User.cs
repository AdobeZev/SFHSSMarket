using System;
using System.Collections.Generic;

using Stocks;

namespace Users
{
    class User
    {

        static class Money
        {
            // Variables
            static List<int> _previousMoney = new List<int>();
            static int _currentMoney = 1000;

            static int _changeRates = 0;
            static int _ogChangeRate = 0;

            // Getter setter
            public static List<int> PreviousMoney {get { return _previousMoney; } }
            public static int CurrentMoney {get { return _currentMoney;} }

            public static int ChangeRates { get { updateRates(); return _changeRates; } } 
            public static int OgChangeRates { get { updateRates(); return _ogChangeRate; } }

            // Functions

            // Update money
            static void updateMoney(int newAmount)
            {
                // Add the current amount of money to the previous money
                _previousMoney.Add(newAmount);

                // Set current money
                _currentMoney = newAmount;
            }

            public static void AddMoney(int addAmount)
            {
                updateMoney(_currentMoney += addAmount);
            }

            public static void SetMoney(int setAmount)
            {
                updateMoney(setAmount);
            }

            // change rates

            static void updateRates()
            {
                // Check previous money count
                int prevMonLen = _previousMoney.Count;
                int prevMon = 1000;

                // Check if previous money count is greater than zero
                // if so set to latest previous money
                if (prevMonLen > 0) prevMon = _previousMoney[prevMonLen - 1];

                // update og rate
                int prevRate = Math.Abs(prevMon - _currentMoney);

                // Check if prev rate is zero
                _changeRates = (prevRate == 0) ? 0 : (_currentMoney > prevMon) ? prevRate : -prevRate ;

                // Get rate of current money compared to 1k
                int ogPrevRate = Math.Abs(1000 - CurrentMoney);

                _ogChangeRate = (ogPrevRate == 0) ? 0 : (_currentMoney > 1000) ? ogPrevRate : -ogPrevRate; 
            }

        }

        // Variables
        int _userId;

        List<Stock> _enlistedStocks = new List<Stock>();
        List<Stock> _prevStocks = new List<Stock>();

        // Login Info
        string _userName;
        string _passWord;

        // Getter setters
        public int UserId {get { return _userId; } }

        public List<Stock> EnlistedStocks { get { return _enlistedStocks; } set { _enlistedStocks = value; } }

        string UserName { get { return _userName; } }

        // Functions

        // Bool variables
        public bool isUsername(string stringToCheck)
        {
            // Convert string to check into lower string
            stringToCheck = Conversions.String.toLower(stringToCheck);

            // return bool
            return stringToCheck == _userName;
        }

        public bool isPassword(string stringToCheck)
        {
            // Do not lower because password is caps sensitive
            // Return bool
            return stringToCheck == _passWord;
        }

        // Stock functions


        // Initializer
        public User(string newUser, string newPas, int newId)
        {
            // Set variables
            _userName = newUser;
            _passWord = newPas;
            _userId = newId;
        }

    }
}