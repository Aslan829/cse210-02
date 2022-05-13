using System;

namespace cse210_02
{
    public class Player
    {
        public int startingPoints = 100;

        public int AddPoints(int points){
            int newPoints = points + 100;
            return newPoints;
        }

        public int RemovePoints(int points){
            int newPoints = points - 75;
            return newPoints;
        }


    }
}
