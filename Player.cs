using System;

namespace cse210_02
{
    public class Player
    {
        //starting points
        public int startingPoints = 100;

        //Add points
        public int AddPoints(int points){
            int newPoints = points + 100;
            return newPoints;
        }

        //Remove points
        public int RemovePoints(int points){
            int newPoints = points - 75;
            return newPoints;
        }


    }
}
