using System;

namespace game
{
    public class TRex
    {
        public bool jumping;
        public int jumpingSpeed;
        private int force;
        public bool shield;
        private int shieldConter;

        public TRex()
        {
            jumping = false;
            jumpingSpeed = 10;
            force = 12;
            shield = false;
            shieldConter = 0;
        }

        public void CheckJump()
        {
            if (jumping && force < 0)
            {
                jumping = false;
            }
            if (jumping)
            {
                jumpingSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpingSpeed = 12;
            }
        }

        public bool CheckTop(int position)
        {
            if (position >= 380 && !jumping)
            {
                force = 12;
                jumpingSpeed = 0;
                return true;
            }
            return false;
        }

        public void CheckShield(int score)
        {
            if (shieldConter == 0 && shield == true)
                shieldConter = score;
            else if (score - 5 > shieldConter)
            {
                shieldConter = 0;
                shield = false;
            }
        }

        public void ResetTRex()
        {
            force = 12;
            jumpingSpeed = 10;
            jumping = false;
            shield = false;
            shieldConter = 0;
        }
    }
}
