using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rokinect.metier
{
    class Player
    {
        private int lifePoints = 100;
        private int height;
        private int exhaust = 0;
        private Boolean winner;

        public Player(int life, int height)
        {
            this.lifePoints = life;
            this.height = height;
        }

        public  void doBlow(Gesture gesture)
        {
            
        }


    }
}
