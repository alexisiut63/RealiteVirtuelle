using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rokinect.metier
{
   abstract class Gesture

    {
        private int velocity;
        private int maxHeight;
        private int strenght;

        public abstract void move();
    }
}
