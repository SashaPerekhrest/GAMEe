using System;
using NUnit.Framework;

namespace game.Tests
{
    [TestFixture]
    class Tests
    {
        [Test]
        public void ResetGameTest()
        {
            var game = new GameModel();
            game.score++;
            game.trex.jumpingSpeed = 100;
            game.ResetValue();
            Assert.AreEqual(0, game.score);
            Assert.AreEqual(new GameModel().trex.jumpingSpeed, game.trex.jumpingSpeed);
        }

        [Test]
        public void MoveBonusTest()
        {
            var game = new GameModel();
            Assert.AreEqual(0, game.MoveBonus(-100, -30, 1000));
            game.score = 10;
            Assert.AreEqual(1200, game.MoveBonus(-100, -30, 1000));
        }

        [Test]
        public void ShieldTest()
        {
            var game = new GameModel();
            game.trex.shield = true;
            game.trex.CheckShield(1);
            Assert.AreEqual(true, game.trex.shield);
            game.trex.CheckShield(10);
            Assert.AreEqual(false, game.trex.shield);
        }

        [Test]
        public void MoveObstacleTest()
        {
            var game = new GameModel();
            Assert.AreEqual(1000, game.MoveObstacle(-100, -30, 1000),800);
        }

        [Test]
        public void JumpingTest()
        {
            var game = new GameModel();
            game.trex.jumping = false;
            Assert.AreEqual(true, game.CheckTop(400));
        }
    }
}