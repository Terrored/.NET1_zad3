using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET1_zad3
{
    class Deck
    {
        public Card Card { get; set; }
        public CardComperer CardComperer;


        public List<Card> Deck1 = new List<Card>()
        {
            new Card() {Number = 1, Suit = Suits.Kier, Value = Values.As},
            new Card() {Number = 2, Suit = Suits.Karo, Value = Values.Trójka},
            new Card() {Number = 3, Suit = Suits.Pik, Value = Values.Dziewiątka},
            new Card() {Number = 4, Suit = Suits.Trefl, Value = Values.Siódemka},
            new Card() {Number = 5, Suit = Suits.Trefl, Value = Values.Król},
            new Card() {Number = 5, Suit = Suits.Trefl, Value = Values.Król},

        };

        
        
        public string Compare2Cards(Card a, Card b)
        {
            string description = "Porównuje karty: " + a.ToString() + " oraz "+ b.ToString() + ". ";

            if (a.Value > b.Value)
                description+= a.ToString() + " jest większa.";
            if (a.Value < b.Value)
                description+= b.ToString() + " jest większa.";
            if(a.Value==b.Value)
                description+= "Karty są równe.";
            return description;
        }

        public void FindMaxAndMin()
        {
            Deck1.Sort(new CardComperer());
            Console.WriteLine("Największa karta to : " + Deck1[0].ToString());
            Console.WriteLine("Najmniejsza karta to : " + Deck1[Deck1.Count-1]);
        }

        public void WriteAllCards()
        {
            foreach (Card card in Deck1)
            {
                Console.WriteLine(card.ToString());
            }
        }

        public void RemoveDuplicates()
        {
            IEnumerable<Card> deck2 = Deck1.Distinct(); // Żeby to działało potrzebowałem IEquatable<Card> w klasie Card. Można usuwanie duplikatów zrobić łatwiej?
            Console.WriteLine("Karty bez duplikatów:");
            foreach (Card card in deck2)
            {
                Console.WriteLine(card.ToString());
            }

        }
    }
}
