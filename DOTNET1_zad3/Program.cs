using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET1_zad3
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Deck deck = new Deck();

            deck.WriteAllCards();
            Console.WriteLine("**************************************************************");
            Console.WriteLine(deck.Compare2Cards(deck.Deck1[3],deck.Deck1[4]));
            Console.WriteLine("**************************************************************");
            deck.FindMaxAndMin();
            Console.WriteLine("**************************************************************");
            deck.WriteAllCards();
            Console.WriteLine("**************************************************************");
            deck.RemoveDuplicates();
            
            

            Console.ReadKey();
        }
    }
}
