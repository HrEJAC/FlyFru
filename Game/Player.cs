using System;
using static System.Math;

namespace Game
{
    public class Player : Entity
    {
        private int points;

        public Player(Shape shape, string img) : base(shape, img)
        {
            points = 0;
        }

        public void IncrementPoints() {
            points ++;
        }

        public int GetPoints(){
            return points;
        }

        public void ManageSpeed(){
            
        }

        public void MoveV(){
            shape.Angle += shape.AngFreq;
            shape.PosY = (float) (shape.PosY + Sin(shape.Angle) * shape.Speed);
        }
    }
}
