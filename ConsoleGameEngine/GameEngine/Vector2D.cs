using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class Vector2D
    {
        private int _x;
        private int _y;

        public Vector2D(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public Vector2D()
        {

        }

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public static Vector2D operator +(Vector2D p1, Vector2D p2)
        {
            Vector2D newPos = new Vector2D(p1.X + p2.X, p1.Y + p2.Y);

            return newPos;
        }

        public override string ToString()
        {
            return $"({this.X} , {this.Y})";
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is Vector2D)
                return this.GetHashCode() == obj.GetHashCode();
            return false;
        }
    }
}
