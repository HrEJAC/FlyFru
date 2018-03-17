using System;
using System.Collections.Generic;

namespace Game
{
    public class Sequence
    {
        public List<Obstacle> Container;
        public float PosX;
        public float Length;

        public Sequence(float startX)
        {
            PosX = startX;
            Container = new List<Obstacle> { };
        }

        public void CreateObstacle(
            float relX, float width, float Y, float height, string img)
        {
            Container.Add(new Obstacle(
                            new Shape(PosX + relX, Y,
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