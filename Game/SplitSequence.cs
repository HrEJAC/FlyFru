using System;
using System.Collections.Generic;

namespace Game
{
    public class SplitSequence : ISequence
    {
        public List<Obstacle> Container;
        public float PosX;
        public float length;

        public SplitSequence(float startX)
        {
            PosX = startX;
            Container = new List<Obstacle> { };
        }

        public void CreateObstacle(
            float relX, float width, float Y, float height, string img)
        {
            Container.Add(new Obstacle(
                            new Shape(PosX + relX, Y - height,
                                      width, height), img));
        }

        public void CreateObstacles()
        {
            throw new NotImplementedException();
        }

        public void Move(float step)
        {
            PosX -= step;
            foreach (Obstacle obs in Container)
            {
                obs.shape.PosX -= step;
            }
        }
    }
}
