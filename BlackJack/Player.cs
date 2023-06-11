using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Player
    {
        int numberOfCard;
        List<Card> cards;
        int Sum;
        int loaiNguoi;
        public Player()
        {
            numberOfCard = 0;
            cards = new List<Card>();
            Sum = 0;
        }
        public int getLoaiNguoi()
        {
            return this.loaiNguoi;
        }
        public void setLoaiNguoi(int a)
        {
            this.loaiNguoi = a;
        }
       
        public int getNumberCard(int i=0)
        {
            numberOfCard += i;
            return numberOfCard;
        }
        public void addCard(Card temp)
        {
            cards.Add(temp);
        }
        public string getAllCard()
        {
            string temp = "";
            foreach (Card c in cards)
            {
                temp += c.getIdCard();
            }
            return temp;
        }
        public int getSum()
        {
            int sum = 0;
            int countA = 0; // Initialize count of A cards to 0
            foreach (Card c in cards)
            {
                if (c.getValue() == 1) // If the card is an A, increment the count of A cards
                {
                    countA++;
                }
                else // If the card is not an A, add its value to the sum
                {
                    sum += c.getValue();
                }
            }

            // Adjust the sum based on the count of A cards
            for (int i = 0; i < countA; i++)
            {
                if (sum + 11 <= 21) // If adding 11 would not cause a bust, use the higher value for A
                {
                    sum += 11;
                }
                else if (sum + 10 <= 21)
                {
                    sum += 10;
                }
                else // Otherwise, use the lower value for A
                {
                    sum += 1;
                }
            }

            Sum = sum;
            return Sum;
        }
        public int getSum(int a)
        {
            Sum += a;
            return Sum;
        }
    }
}
