using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class ObjectNotFoundException : ApplicationException
    {
        public ObjectNotFoundException(string msg):base(msg)
        {

        }

        public ObjectNotFoundException()
        {

        }
    }
}
