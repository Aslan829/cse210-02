using System;

namespace cse210_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //play again?
            bool playAgain = false;

            //loop for the game
            do{
                //Creates the deck
                Deck gameDeck = new Deck();
                Player player = new Player();
                int points = player.startingPoints;

                //sets first card
                int topCard = gameDeck.SetFirstCard();
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
                        points += player.AddPoints(points);
                    }
                    else
                    {
                        points -= player.RemovePoints(points);
                    }
                }   

                Console.WriteLine("Your score is: " + points);

                //want to play again?
                Console.WriteLine("Play again? [y/n] ");
                string playAnswer = Console.ReadLine();

                //play again?
                if(playAnswer == "y"){
                    playAgain = true;
                }
                else if(playAnswer == "n")
                {
                    playAgain = false;
                }

            } while(playAgain);
            

        }
    }
}
