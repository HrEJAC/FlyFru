using System;
namespace Game
{
    public class Shape
    {
        public float PosX;
        public float PosY;
        public float ExtendX;
        public float ExtendY;

        public float Speed;

        public float Angle;
        public float AngFreq;

        public bool DirUp;

        public Shape(float posX, float posY, float extendX, float extendY)
        {
            PosX = posX;
            PosY = posY;
            ExtendX = extendX;
            ExtendY = extendY;
        }

        public Shape(float posX, float posY, float extendX,
                     float extendY, float speed, float angle,
                     float angFreq){
            PosX = posX;
            PosY = posY;
            ExtendX = extendX;
            ExtendY = extendY;
            Speed = speed;
            Angle = angle;
            AngFreq = angFreq;
            DirUp = true;
        }

        public static bool Collision (Shape player, Shape obstacle) {
            
            var PlayerLeftX = player.PosX; 
            var PlayerLowerY = player.PosY;
            var PlayerRightX = player.PosX + player.ExtendX;
            var PlayerUpperY = player.PosY + player.ExtendY;

            var ObstacleLeftX = obstacle.PosX;
            var ObstacleLowerY = obstacle.PosY;
            var ObstacleRightX = obstacle.PosX + obstacle.ExtendX;
            var ObstacleUpperY = obstacle.PosY + obstacle.ExtendY;

            if ((PlayerRightX >= ObstacleLeftX &&
                 PlayerRightX <= ObstacleRightX &&
                 PlayerUpperY >= ObstacleLowerY &&
                 PlayerUpperY <= ObstacleUpperY) ||
                
                (PlayerRightX >= ObstacleLeftX &&
                 PlayerRightX <= ObstacleRightX &&
                 PlayerLowerY <= ObstacleUpperY &&
                 PlayerLowerY >= ObstacleLowerY) ||
               
                (PlayerLeftX >= ObstacleLeftX &&
                 PlayerLeftX <= ObstacleRightX &&
                 PlayerUpperY >= ObstacleLowerY &&
                 PlayerUpperY <= ObstacleUpperY) ||
               
                (PlayerLeftX >= ObstacleLeftX &&
                 PlayerLeftX <= ObstacleRightX &&
                 PlayerLowerY <= ObstacleUpperY &&
                 PlayerLowerY >= ObstacleLowerY))
            {
                return true;
            }

            return false;
        }
    }
}
