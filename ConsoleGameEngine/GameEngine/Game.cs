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
}
