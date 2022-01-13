using System;
using System.Collections.Generic;

namespace Conversions
{
    static class Integer
    {
        // To string 
        public static string toString(int changeInt)
        {
            // Initialize variable
            string convertedString = changeInt.ToString();

            // check if string
            if (convertedString.GetType() != typeof(string)) return "|ERROR|";
            
            return convertedString;

        }
    }

    static class String
    {

        // To int
        public static int toInt(string changeString)
        {
            // Initialize variable
            int convertedInt;

            // Try to parse
            if (!Int32.TryParse(changeString, out convertedInt)) return 0;

            // Change at end
            return convertedInt;
            
        }

        // To Lower
        public static string toLower(string stringToConvert)
        {
            // variables
            string returnString = "";
            
            foreach(char x in stringToConvert)
                returnString += Char.ToLower(x);

            return returnString;
        }
    }
}