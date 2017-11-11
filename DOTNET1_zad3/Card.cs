using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET1_zad3
{
    class Card : IEquatable<Card> // Ten interfejs zastosowałem tylko po to żeby metoda RemoveDuplicates działała. Znalazłem coś takiego na MSDN.
    {

        public int Number { get; set; }
        public Values Value { get; set; }
        public Suits Suit { get; set; }

        public override string ToString()
        {
            return Value + " " + Suit;
        }
        public bool Equals(Card other) // Tutaj są dwie metody tego interfejsu . Za bardzo nie rozumiem co się tutaj dzieje no ale efekt jest. 
                                       // Można jakoś prościej usunąć duplikat karty?
        {
            if (Object.ReferenceEquals(other, null)) return false;
            if (Object.ReferenceEquals(this, other)) return true;
            return Value.Equals(other.Value) && Suit.Equals(other.Suit);
        }
        
        public override int GetHashCode()
        {
            int hashProductName = Suit == null ? 0 : Suit.GetHashCode();
            int hashProductCode = Value.GetHashCode();
            return hashProductName ^ hashProductCode;
        }

        
    }
}
