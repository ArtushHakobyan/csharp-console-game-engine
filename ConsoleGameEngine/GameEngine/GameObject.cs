using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    /// <summary>
    /// Base game object class.
    /// </summary>
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
        /// <summary>
        /// This method is called only one time when the game starts.
        /// </summary>
        public virtual void Start()
        {

        }
        /// <summary>
        /// This method will be called in every frame.
        /// </summary>
        public virtual void Update()
        {

        }
        /// <summary>
        /// Renders the object
        /// </summary>
        public virtual void Render()
        {
            Console.SetCursorPosition(this.Pos.X, this.Pos.Y);
            Console.ForegroundColor = this.Color;
            Console.Write(this.Icon);
            Console.ResetColor();
        }
        /// <summary>
        /// Is called when tring to destroy object
        /// </summary>
        public virtual void Destroy()
        {

        }
        /// <summary>
        /// This method is called when other game object collides to this
        /// </summary>
        /// <param name="obj">The game object that collides with this</param>
        public virtual void Collision(GameObject obj)
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
