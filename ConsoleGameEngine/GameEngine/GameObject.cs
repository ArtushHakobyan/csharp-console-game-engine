using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class GameObject
    {
        public string Name { get; set; }
        public char Icon { get; set; }
        public ConsoleColor Color { get; set; }
        public Vector2D Pos { get; set; }

        public GameObject(int x, int y, char ico, ConsoleColor col)
        {
            this.Pos = new Vector2D(x, y);
            this.Icon = ico;
            this.Color = col;
        }

        public GameObject(char ico, ConsoleColor col, Vector2D pos)
        {
            this.Icon = ico;
            this.Color = col;
            this.Pos = pos;
        }

        public GameObject()
        {

        }

        public virtual void Start()
        {

        }

        public virtual void Update()
        {

        }

        public virtual void Render()
        {
            Console.SetCursorPosition(this.Pos.X, this.Pos.Y);
            Console.ForegroundColor = this.Color;
            Console.Write(this.Icon);
            Console.ResetColor();
        }

        public virtual void Destroy()
        {

        }

        public override string ToString()
        {
            return $"{this.Pos.ToString()}, {this.Icon}, {this.Color}";
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is GameObject)
                return this.GetHashCode() == obj.GetHashCode();
            return false;
        }
    }
}
