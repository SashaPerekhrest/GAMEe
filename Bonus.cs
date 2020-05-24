using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class Bonus
    {
        private int checkScore = 3;
        private Random rnd = new Random();

        public int MoveBonus(int position, int width, int clientSize, int score)
        {
            var potestas = rnd.Next(0, 3);
            if (score > checkScore)
            {
                if (position + width < -120)
                {
                    checkScore += 15 + potestas * 5;
                    return clientSize + 200;
                }
                return -10;
            }
            return 0;
        }

        public void ResetBonus() => checkScore = 3;
    }
}