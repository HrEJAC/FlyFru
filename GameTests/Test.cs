using NUnit.Framework;
using System;
using Game;

namespace GameTests
{
    [TestFixture()]
    public class Test
    {
        private Shape Player;
        private Shape Obstacle;
        private Player PlayerTest;
        // Testing Collision:
        [Test()]
        public void TestNoCollision()
        {
            Player = new Shape(0.0f, 0.0f, 0.1f, 0.1f);
            Obstacle = new Shape(1.0f, 1.0f, 0.1f, 0.1f);
            Assert.IsFalse(Shape.Collision(Player, Obstacle));
        }

        [Test()]
        public void TestCollisionPlayerLowerLeftCorner()
        {
            Player = new Shape(0.5f, 0.5f, 1.0f, 1.0f);
            Obstacle = new Shape(0.0f, 0.0f, 1.0f, 1.0f);
            Assert.IsTrue(Shape.Collision(Player, Obstacle));
        }

        [Test()]
        public void TestCollisionPlayerLowerRightCorner()
        {
            Player = new Shape(0.0f, 0.5f, 1.0f, 1.0f);
            Obstacle = new Shape(0.5f, 0.0f, 1.0f, 1.0f);
            Assert.IsTrue(Shape.Collision(Player, Obstacle));
        }

        [Test()]
        public void TestCollisionPlayerUpperRightCorner()
        {
            Player = new Shape(0.0f, 0.0f, 1.0f, 1.0f);
            Obstacle = new Shape(0.5f, 0.5f, 1.0f, 1.0f);
            Assert.IsTrue(Shape.Collision(Player, Obstacle));
        }

        [Test()]
        public void TestCollisionPlayerUpperLeftCorner()
        {
            Player = new Shape(0.5f, 0.0f, 1.0f, 1.0f);
            Obstacle = new Shape(0.0f, 0.5f, 1.0f, 1.0f);
            Assert.IsTrue(Shape.Collision(Player, Obstacle));
        }
        // Fikses hvis det er problem
        [Test()]
        public void TestCollisionPlayerstabinmiddle()
        {
            Player = new Shape(0.4f, 0.4f, 1.5f, 1.5f);
            Obstacle = new Shape(0.5f, 0.5f, 1.0f, 1.0f);
            Assert.IsFalse(Shape.Collision(Player, Obstacle));
        }
        // Testing Player Functions:
        [Test()]
        public void TestPlayerPoints() {
            Player = new Shape(0.5f, 0.5f, 0.1f, 0.1f, 0.0f, 0.0f, 0.3f);
            PlayerTest = new Player(Player, "lort");
            for (int i = 0; i < 5; i ++) {
                PlayerTest.IncrementPoints();
            }
            Assert.AreEqual(PlayerTest.GetPoints(), 5);
        }
        //[Test()]
        //public void TestPlayerPointsMaxInt()
        //{
        //    Player = new Shape(0.5f, 0.5f, 0.1f, 0.1f, 0.0f, 0.0f, 0.3f);
        //    PlayerTest = new Player(Player, "lort");
        //    for (int i = 0; i < Int32.MaxValue; i++)
        //    {
        //        PlayerTest.IncrementPoints();
        //    }
        //    Assert.AreEqual(PlayerTest.GetPoints(), (Int32.MaxValue));
        //}
        [Test()]
        public void TestPlayer() {
            Player = new Shape(0.5f, 0.5f, 0.1f, 0.1f, 0.2f, 0.0f, 0.3f);
            PlayerTest = new Player(Player, "");
            PlayerTest.MoveV();
            Assert.AreEqual(PlayerTest.shape.Angle, 0.3f);
            Assert.GreaterOrEqual(0.56f, System.Math.Abs(PlayerTest.shape.PosY));
        }
    }
}
