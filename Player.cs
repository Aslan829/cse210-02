using System;

namespace cse210_02
{
    public class Player
    {
        public int startingPoints = 300;

        public int AddPoints(int points){
            points += 100;
            return points;
        }

        public int RemovePoints(int points){
            points -= 75;
            return points;
        }


    }
}
