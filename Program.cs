using System;

namespace cse210_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //play again?
            bool playAgain = false;

    //Creates the deck
            Deck gameDeck = new Deck();
            Player player = new Player();
            int points = player.startingPoints;
            int topCard = gameDeck.SetFirstCard();
            
            //loop for the game
            do{
                //sets first card
                
                Console.WriteLine("The card is: " + topCard);
                //shuffle the deck 
                gameDeck.cardDeck = gameDeck.Shuffle(topCard);
                //get next card
                gameDeck.nextCard = gameDeck.SetNextCard();

                //compare cards
                Console.WriteLine("Higher or Lower [h/l] ");
                string highLow = Console.ReadLine();
                Console.WriteLine("Next card was: " + gameDeck.nextCard);
                if (highLow == "h"){
                    if(topCard < gameDeck.nextCard){
                        points = player.AddPoints(points);
                    }
                    else
                    {
                        points = player.RemovePoints(points);
                    }
                }
                else if (highLow == "l")
                {
                    //Points is not acting right
                    if(topCard > gameDeck.nextCard){
                        points = player.AddPoints(points);
                    }
                    else
                    {
                        points = player.RemovePoints(points);
                    }
                }   

                Console.WriteLine("Your score is: " + points);

                //want to play again? and Points above 0?
                if (points > 0){
                    Console.WriteLine("Play again? [y/n] ");
                    string playAnswer = Console.ReadLine();

                     //play again?
                    if(playAnswer == "y"){
                         playAgain = true;
                        topCard = gameDeck.nextCard;

                    }
                    else if(playAnswer == "n")
                    {
                        playAgain = false;
                    }

                } 
               

            } while(playAgain);
            

        }
    }
}
