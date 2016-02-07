using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rokinect.metier
{
    class SkippingRopeFactory : BoxingObjectFactory
    {

        override
            public BoxingObject createBO()
        {
            return new SkippingRope();
        }
    }
}
