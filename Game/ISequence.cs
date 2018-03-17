using System;
using System.Collections.Generic;

namespace Game
{
    public interface ISequence
    {
        void CreateObstacle(
            float relX, float width, float Y, float height, string img);

        void CreateObstacles();

        void Move(float step);
    }
}