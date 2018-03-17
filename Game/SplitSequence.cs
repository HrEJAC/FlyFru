using System;
namespace Game
{
    public class SplitSequence : Sequence
    {
        public SplitSequence(float startX) : base(startX)
        {
        }

        public override void CreateObstacles(){
            Length = 1.45f;
            Container.Add(new Obstacle(new Shape(0.0f, 0.0f, 0.15f, 0.3f), ""));
            Container.Add(new Obstacle(new Shape(0.0f, 0.7f, 0.15f, 0.3f), ""));
            Container.Add(new Obstacle(new Shape(0.2f, 0.25f, 0.3f, 0.5f), ""));
            Container.Add(new Obstacle(new Shape(0.8f, 0.0f, 0.15f, 0.3f), ""));
            Container.Add(new Obstacle(new Shape(0.8f, 0.7f, 0.15f, 0.3f), ""));
            Container.Add(new Obstacle(new Shape(1.0f, 0.25f, 0.3f, 0.5f), ""));
            Container.Add(new Obstacle(new Shape(1.3f, 0.0f, 0.15f, 0.3f), ""));
            Container.Add(new Obstacle(new Shape(1.3f, 0.7f, 0.15f, 0.3f), ""));
        }
    }
}
