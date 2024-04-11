using System;

namespace SortingCards;

public class Card : IComparable<Card> {
    public int rank = 0;
    public int suit = 0;

    public Card(int rank, int suit) {
        this.rank = rank;
        this.suit = suit;
    }

    public int CompareTo(Card c) {
        // CODE HERE!
        
        if (this.suit != c.suit) {
            if (this.suit < c.suit) {
                return -1;
            }
            else {
                return 1;
            }
            
        }
        else if (this.suit == c.suit) {
            if (this.rank < c.rank) {
                return -1;
            }
            else {
                return 1;
            }
        }
        else {
            return 0;
        }
         

         
        throw new NotImplementedException();
    }

    public override string ToString() {
        return $"{this.rank}, {this.suit}";
    }
}
