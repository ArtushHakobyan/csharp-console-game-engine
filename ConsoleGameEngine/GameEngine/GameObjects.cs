using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class GameObjects
    {
        private List<GameObject> _gameObjects = new List<GameObject>();

        public void Add(GameObject obj)
        {
            _gameObjects.Add(obj);
        }

        public bool Remove(GameObject obj)
        {
            return _gameObjects.Remove(obj);
        }
    }
}
