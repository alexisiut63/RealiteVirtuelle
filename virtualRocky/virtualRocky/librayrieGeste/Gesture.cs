using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Kinect;

namespace virtualRocky.librayrieGeste
{
    public abstract class Gesture
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public abstract void testGesture(Body b);


        protected GestureRecognised gestureRegognised;
        public event GestureRecognised GestureRegognised
        {
            add { gestureRegognised += new GestureRecognised(value); }
            remove { gestureRegognised -= value; }
        }


    }
}

