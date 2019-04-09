using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GameEngine
{
    public delegate void KeyPressEvent();

    public class Game
    {
        private List<GameObject> gameObjects = new List<GameObject>();

        public static event KeyPressEvent OnRightKey;
        public static event KeyPressEvent OnLeftKey;
        public static event KeyPressEvent OnUpKey;
        public static event KeyPressEvent OnDownKey;

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
            Thread keysThread = new Thread(CheckForKeys);
            keysThread.IsBackground = true;
            keysThread.Start();
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

        private static void CheckForKeys()
        {
            ConsoleKey key;

            while (true)
            {
                key = Console.ReadKey().Key;

                switch (key)
                {
                    case ConsoleKey.RightArrow:
                        Game.OnRightKey();
                        break;
                    case ConsoleKey.LeftArrow:
                        Game.OnLeftKey();
                        break;
                    case ConsoleKey.UpArrow:
                        Game.OnUpKey();
                        break;
                    case ConsoleKey.DownArrow:
                        Game.OnDownKey();
                        break;
                }
            }
        }
    }
}
