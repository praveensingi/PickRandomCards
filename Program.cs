using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick: ");
            string strNumOfCards = Console.ReadLine();
            if (int.TryParse(strNumOfCards, out int numOfCards)) {
                string[] cardsPicked = CardPicker.PickSomeCards(numOfCards);
                foreach (string card in cardsPicked)
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}
