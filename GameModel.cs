using System;

namespace game
{
    public class GameModel
    {
        public int score;
        public TRex trex;
        private Obstacle obstacle;
        private Bonus bonus;

        public GameModel()
        {
            trex = new TRex();
            obstacle = new Obstacle();
            bonus = new Bonus();
            score = 0;
        }

        public void ResetValue()
        {
            trex.ResetTRex();
            score = 0;
            obstacle.ResetObstacle();
            bonus.ResetBonus();
        }

        public int MoveObstacle(int position, int width, int clientSize) =>
           obstacle.MoveObstacle(position, width, clientSize, ref score);

        public int MoveBonus(int position, int width, int clientSize) =>
           bonus.MoveBonus(position, width, clientSize, score);

        public void CheckJump() => trex.CheckJump();

        public bool CheckTop(int position) => trex.CheckTop(position);
    }
}
