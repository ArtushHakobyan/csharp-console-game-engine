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

        public int Count => _gameObjects.Count;

        public GameObject this[string name]
        {
            get
            {
                foreach (GameObject gameObject in _gameObjects)
                {
                    if (gameObject.Name == name)
                        return gameObject;
                }
                return null;
            }
            set
            {
                for (int i = 0; i < _gameObjects.Count; i++)
                {
                    if (_gameObjects[i].Name == name)
                        _gameObjects[i] = value;
                    return;
                }
                throw new ObjectNotFoundException();
            }
        }

        public GameObject this[int index]
        {
            get
            {
                if (index >= 0 && index < Count)
                {
                    return _gameObjects[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < Count)
                {
                    _gameObjects[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public void Add(GameObject obj)
        {
            _gameObjects.Add(obj);
        }

        public bool Remove(GameObject obj)
        {
            return _gameObjects.Remove(obj);
        }

        public bool Remove(string objectName)
        {
            return _gameObjects.Remove(this[objectName]);
        }
    }
}
