using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.cook
{
    /// <summary>
    /// The legacy API which must be converted to the new structure
    /// </summary>
    class MeatDatabase
    {
        // Temps from http://www.foodsafety.gov/keep/charts/mintemp.html
        public float GetSafeCookTemp(string meat, TemperatureType tempType)
        {
            if (tempType == TemperatureType.Fahrenheit)
            {
                switch (meat)
                {
                    case "beef":
                    case "pork":
                        return 145f;

                    case "chicken":
                    case "turkey":
                        return 165f;

                    default:
                        return 165f;
                }
            }
            else
            {
                switch (meat)
                {
                    case "beef":
                    case "veal":
                    case "pork":
                        return 63f;

                    case "chicken":
                    case "turkey":
                        return 74f;

                    default:
                        return 74f;
                }
            }
        }

        public int GetCaloriesPerOunce(string meat)
        {
            switch (meat.ToLower())
            {
                case "beef": return 71;
                case "pork": return 69;
                case "chicken": return 66;
                case "turkey": return 38; //Wow, turkey is lean!
                default: return 0;
            }
        }

        public double GetProteinPerOunce(string meat)
        {
            switch (meat.ToLower())
            {
                case "beef": return 7.33f;
                case "pork": return 7.67f;
                case "chicken": return 8.57f;
                case "turkey": return 8.5f;
                default: return 0d;
            }
        }
    }
}
