using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string replyFromDavid = new John().AskQuestion("how are you?");
            Console.WriteLine("Reply From David [French Speaker can Speak and Understand only French] :  " + replyFromDavid);
            Console.WriteLine();
            string replyFromJohn = new David().AskQuestion("où êtes-vous?");
            Console.WriteLine("Reply From John [English Speaker can Speak and Understand only English] :  " + replyFromJohn);

            Console.Read();
        }
    }
}
