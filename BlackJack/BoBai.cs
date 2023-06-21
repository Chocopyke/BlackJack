using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class BoBai
    {
        List<Card> removeListCards;
        public BoBai()
        {
            removeListCards = new List<Card>();
        }
        private string RandomId() //random giá trị + chất của lá bài    
        {
            string temp="";
            Random random = new Random(); //random các giá trị cho quân bài, nếu > 10 sẽ là các quân bài J, Q, K
            int i = random.Next(1, 14);
            switch (i)
            {
                case 11:
                    temp = "J";
                    break;
                case 12:
                    temp = "Q";
                    break;
                case 13:
                    temp = "K";
                    break;
                default:
                    temp = i.ToString();
                    break;
            }
            i = random.Next(1, 5); //random chất cơ, rô, chuồn, bích
            switch (i){
                case 1:
                    temp += "R";//rô
                    break;
                case 2:
                    temp += "B"; //bích
                    break;
                case 3:
                    temp += "H";// chuồn
                    break;
                case 4:
                    temp += "C";//cơ
                    break;
            } 
            return temp;
        }
        private bool AddRemoveList(string id) //đánh dấu xem lá bài đã được lấy ra khỏi bộ bài hay chưa
        {
            foreach(Card c in removeListCards)
            {
                if (c.getIdCard() == id)
                    return false;
            }
            return true;
        }
        public Card getCard() //rút bài
        {
            string id = "";
            do
            {
                id = RandomId();
            } while (AddRemoveList(id) != true);
            Card card = new Card(id);
            this.removeListCards.Add(card); //lá được rút sẽ bị loại ra ngoài
            return card;
        }
        public void resetRomeveList()
        {
            removeListCards.Clear();
        }
    }
}