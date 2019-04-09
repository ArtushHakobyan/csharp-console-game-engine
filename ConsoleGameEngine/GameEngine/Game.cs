using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class Game
    {
        private List<GameObject> gameObjects = new List<GameObject>();

        public void Add(GameObject gameObject)
        {
            gameObjects.Add(gameObject);
        }

        public bool Remove(GameObject gameObject)
        {
            return gameObjects.Remove(gameObject);
        }

        public void Start()
        {
            foreach(GameObject item in gameObjects)
            {
                item.Start();
            }
        }

        public void Update()
        {
            foreach(GameObject item in gameObjects)
            {
                item.Update();
            }
        }

        public void Render()
        {
            foreach(GameObject item in gameObjects)
            {
                item.Render();
            }
        }
    }

    public class GameObject
    {
        public char Icon { get; set; }
        public ConsoleColor Color { get; set; }
        public Position Pos;

        public GameObject(int x, int y, char ico, ConsoleColor col)
        {
            this.Pos = new Position(x, y);
            this.Icon = ico;
            this.Color = col;
        }

        public GameObject(char ico, ConsoleColor col, Position pos)
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

    public class Position
    {
        private int _x;
        private int _y;

        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public Position()
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
                if (value >= 0 && value < Console.WindowWidth)
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
                if (value >= 0 && value < Console.WindowHeight)
                    _y = value;
            }
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
            if (obj is Position)
                return this.GetHashCode() == obj.GetHashCode();
            return false;
        }
    }
}
