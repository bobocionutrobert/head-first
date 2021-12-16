// See https://aka.ms/new-console-template for more information
using PickRandomCaeds;

Console.WriteLine("Enter the numbers of cards to pick");
string line = Console.ReadLine();

if(int.TryParse(line, out int numberofCards))
{
    foreach(string card in CardPicker.PickSomeCards(numberofCards))
    {
        Console.WriteLine(card);
    }
}
else
{
    Console.WriteLine("Please enter valid number");
}
