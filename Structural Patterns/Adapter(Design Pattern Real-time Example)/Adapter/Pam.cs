using System;
using System.Collections.Generic;

namespace Adapter
{
    // Adapter or Translator
    // Pam can speak and understand both English and French
    // She acts as an Adapter or Translator
    public class Pam : ITarget
    {
        static Dictionary<string, string> EnglishFrenchDictionary = new Dictionary<string, string>();
        static Dictionary<string, string> FrenchEnglishDictionary = new Dictionary<string, string>();
        David david = new David();
        John john = new John();

        static Pam()
        {
            EnglishFrenchDictionary.Add("how are you?", "comment allez-vous?");
            EnglishFrenchDictionary.Add("I am in USA", "Je suis aux Etats-Unis");
            FrenchEnglishDictionary.Add("Je suis trC(s bien", "I am fine");
            FrenchEnglishDictionary.Add("oC9 C*tes-vous?", "where are you?");
        }
        public string TranslateAndTellToOtherPerson(string Words, string ConvertToWhichLanguage)
        {
            if (ConvertToWhichLanguage.Equals("English", StringComparison.InvariantCultureIgnoreCase))
            {
                string EnglishWords = ConvertToEnglish(Words);
                Console.WriteLine("\nPam Converted \"" + Words + " \" to \"" + EnglishWords + " and send the question to John");
                string EnglishWordsReply = john.AnswerFortheQuestion(EnglishWords);
                Console.WriteLine("Pam Got reply from John in English : " + "\"" + EnglishWordsReply + "\"");
                string FrenchConverted = ConvertToFrench(EnglishWordsReply);
                Console.WriteLine("Pam Converted " + "\"" + EnglishWordsReply + "\"" + " to " + "\"" + FrenchConverted + "\"" + " and send back to David\n");
                return FrenchConverted;
            }
            else if (ConvertToWhichLanguage.Equals("French", StringComparison.InvariantCultureIgnoreCase))
            {
                string FrenchWords = ConvertToFrench(Words);
                Console.WriteLine("\nPam Converted \"" + Words + " \" to \"" + FrenchWords + " and send the question to David");
                string FrenchWordsReply = david.AnswerFortheQuestion(FrenchWords);
                Console.WriteLine("Pam Got reply from David in French : " + "\"" + FrenchWordsReply + "\"");
                string EnglishConverted = ConvertToEnglish(FrenchWordsReply);
                Console.WriteLine("Pam Converted " + "\"" + FrenchWordsReply + "\"" + " to " + "\"" + EnglishConverted + "\"" + " and send back to John\n");
                return EnglishConverted;
            }
            else
            {
                return "Sorry Cannot Covert";
            }
        }
        public string ConvertToFrench(string Words)
        {
            return EnglishFrenchDictionary[Words];
        }
        public string ConvertToEnglish(string Words)
        {
            return FrenchEnglishDictionary[Words];
        }
    }
}
