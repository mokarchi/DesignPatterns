using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            FacebookGroupMediator facebookMediator = new ConcreteFacebookGroupMediator();
            User Ram = new ConcreteUser(facebookMediator, "Ram");
            User Dave = new ConcreteUser(facebookMediator, "Dave");
            User Smith = new ConcreteUser(facebookMediator, "Smith");
            User Rajesh = new ConcreteUser(facebookMediator, "Rajesh");
            User Sam = new ConcreteUser(facebookMediator, "Sam");
            User Pam = new ConcreteUser(facebookMediator, "Pam");
            User Anurag = new ConcreteUser(facebookMediator, "Anurag");
            User John = new ConcreteUser(facebookMediator, "John");
            facebookMediator.RegisterUser(Ram);
            facebookMediator.RegisterUser(Dave);
            facebookMediator.RegisterUser(Smith);
            facebookMediator.RegisterUser(Rajesh);
            facebookMediator.RegisterUser(Sam);
            facebookMediator.RegisterUser(Pam);
            facebookMediator.RegisterUser(Anurag);
            facebookMediator.RegisterUser(John);
            Dave.Send("dotnettutorials.net - this website is very good to learn Design Pattern");
            Console.WriteLine();
            Rajesh.Send("What is Design Patterns? Please explain ");
            Console.Read();
        }
    }
}
