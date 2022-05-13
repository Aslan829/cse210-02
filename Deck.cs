using System;
using System.Collections.Generic;

namespace cse210_02
{
    public class Deck
    {
        //Makes the list of cards
        public List<int> cardDeck;
        public int nextCard;
        
        //set the top card
        public int SetFirstCard(){
            Random random = new Random();
            int newNum = random.Next(1, 13);
            return newNum;

        }

        //Set the "next card" variable
        public int SetNextCard(){
            nextCard = this.cardDeck[0];
            return nextCard;
        }

        
        
        //Shuffle Deck
        public List<int> Shuffle(int topCard){
            var random = new Random();
            var shuffleList = new List<int>();

            //set up the new deck of 13 cards with random numbers 1-13.
                int whileNum = 0;
                do 
                {
                    whileNum = random.Next(1,14);
                    bool isRandom = true;
                    //Make sure the new value doesn't match the number already out of the deck or value in deck
                    if(shuffleList.Count != 0)
                    {
                        for(int x = 0; x < shuffleList.Count; x++){

                            if(whileNum == shuffleList[x]){
                                isRandom = false;
                            }
                            if(isRandom == false){
                                break;
                            }
                        }
                    }
                    if(whileNum != topCard && isRandom == true){
                        shuffleList.Add(whileNum);
                    }
                } while(shuffleList.Count != 12);


           // }
            return shuffleList;
        }

        //public int deal()
    }
}
