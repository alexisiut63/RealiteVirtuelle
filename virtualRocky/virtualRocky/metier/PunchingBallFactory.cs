using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rokinect.metier
{
    class PunchingBallFactory : BoxingObjectFactory
    {
        override
            public BoxingObject createBO()
        {
            return new PunchingBall();
        }
    }
}
