using System;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        GameModel game;

        public Form1()
        {
            game = new GameModel();
            InitializeComponent();
            resetGame();
        }

        private void gameEvent(object sender, EventArgs e)
        {
            trex.Top += game.trex.jumpingSpeed;
            scoreText.Text = "Score: " + game.score;

            game.CheckJump();
            game.trex.CheckShield(game.score);

            if (game.trex.shield)
                icon.Image = Properties.Resources.pixel_shield_2021369;
            else icon.Image = Properties.Resources.white;

            if (game.CheckTop(trex.Top))
                trex.Top = floor.Top - trex.Height;

            foreach (Control x in this.Controls)
                ControlObjects(x);
        }

        private void ControlObjects(Control x)
        {
            if (x.Tag == "obstacle")
            {
                x.Left += game.MoveObstacle(x.Left, x.Width, this.ClientSize.Width);

                if (trex.Bounds.IntersectsWith(x.Bounds) && !game.trex.shield)
                {
                    gameTimer.Stop();
                    trex.Image = Properties.Resources.dead;
                    scoreText.Text += "  Press R to restart";
                }
            }
            if (x.Tag == "bonus")
            {
                x.Left += game.MoveBonus(x.Left, x.Width, this.ClientSize.Width);

                if (trex.Bounds.IntersectsWith(x.Bounds))
                    game.trex.shield = true;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !game.trex.jumping)
                game.trex.jumping = true;
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
                resetGame();

            game.trex.jumping = false;
        }

        public void resetGame()
        {
            game.ResetValue();
            trex.Top = floor.Top - trex.Height;
            scoreText.Text = "Score: " + game.score;
            trex.Image = Properties.Resources.running;

            foreach (Control x in this.Controls)
            {
                if (x.Tag == "obstacle" || x.Tag == "bonus")
                {
                    x.Left = 640 + (x.Left + x.Width * 3);
                }
            }

            gameTimer.Start();
        }
    }
}
