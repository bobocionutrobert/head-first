using System;

namespace Guy
{
    class Program
    {
        static void Main(string[] args)
        {

            Guy joe = new Guy() { Name = "Joe", Cash = 50 };
            Guy bob = new Guy() { Name = "Bob", Cash = 100 };

            while (true)
            {
                joe.WriteMyInfo();
                bob.WriteMyInfo();

                Console.WriteLine("Enter amount : ");

                string howMuch = Console.ReadLine();

                if (howMuch == "") return;

                if(int.TryParse(howMuch, out int amount))
                {
                    Console.WriteLine("Who should give the cash : " );

                    string whichGuy = Console.ReadLine();

                    if(whichGuy == "Joe")
                    {
                        int cashGiven = joe.GiveCash(amount);
                        bob.ReceiveCash(cashGiven);
                    }
                    else if(whichGuy == "Bob")
                    {
                        int cashGiven = bob.GiveCash(amount);
                        joe.ReceiveCash(cashGiven);
                    }
                    else
                    {
                        Console.WriteLine("Please enter Bob or Joe");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an amount");
                }
            }



        }
    }
}
