using Microsoft.Kinect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualRocky.librayrieGeste
{
    public static class GestureEngine
    {
        private static ICollection<Gesture> listGesture = new LinkedList<Gesture>();

        public static void testGesture(Body b)
        {
            foreach (var item in listGesture)
            {
                item.testGesture(null);
            }
        }

        public static void onGestureRecognized(Object obj)
        {
            gestureRegognised(obj);
        }

        public static void ajouterGesture(Gesture gest)
        {
            listGesture.Add(gest);
        }

        private static GestureRecognised gestureRegognised;
        public static event GestureRecognised GestureRegognised
        {
            add { gestureRegognised += value; }
            remove { gestureRegognised -= value; }

        }




    }
}


public delegate void GestureRecognised(Object obj);