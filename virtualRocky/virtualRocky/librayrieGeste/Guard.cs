using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualRocky.librayrieGeste
{
    public class Guard
        : Posture
    {
        

        public override bool testPosture(Microsoft.Kinect.Body b)
        {
            return true;
        }
    }
}
