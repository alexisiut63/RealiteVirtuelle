using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Kinect;

namespace virtualRocky.librayrieGeste
{
    public abstract class Posture
        : Gesture
    {
        override public void testGesture(Microsoft.Kinect.Body b)
        {
            if (testPosture(b))
                gestureRegognised(this);
 //           Console.WriteLine("fin test gesture");
        }

        public abstract bool testPosture(Body b);

    }
}
