using System;
using Flyweight.restaurant;
using Flyweight.characters;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build a document with text
            //string document = "AAZZBBZB";
            //char[] chars = document.ToCharArray();
            //CharacterFactory factory = new CharacterFactory();

            //// extrinsic state
            //int pointSize = 10;
            //foreach (char c in chars)
            //{
            //    pointSize++;
            //    Character character = factory.GetCharacter(c);
            //    character.Display(pointSize);
            //}

            // Build a slider order using patron's input
            Console.WriteLine("Please enter your slider order (use characters B, V, Z with no spaces):");
            var order = Console.ReadLine();
            char[] chars = order.ToCharArray();

            SliderFactory factory = new SliderFactory();

            int orderTotal = 0;

            //Get the slider from the factory
            foreach (char c in chars)
            {
                orderTotal++;
                Slider character = factory.GetSlider(c);
                character.Display(orderTotal);
            }
        }
    }
}
