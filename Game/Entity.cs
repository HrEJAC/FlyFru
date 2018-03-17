using System;
namespace Game
{
    public class Entity
    {
        public Shape shape;
        public string Image;

        public Entity(Shape Shape, string Img)
        {
            shape = Shape;
            Image = Img;
        }
    }
}
