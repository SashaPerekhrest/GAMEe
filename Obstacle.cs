using System;

namespace game
{
    class Obstacle
    {
        private int obstacleSpeed;
        private Random rnd;

        public Obstacle()
        {
            rnd = new Random();
            obstacleSpeed = 10;
        }

        public int MoveObstacle(int position, int width, int clientSize, ref int score)
        {
            if (position + width < -120)
            {
                score++;
                if (score >= 10)
                {
                    obstacleSpeed = 11;
                }
                return clientSize + rnd.Next(200, 800);
            }
            return -obstacleSpeed;
        }

        public void ResetObstacle() => obstacleSpeed = 10;
    }
}