using Microsoft.Kinect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public delegate void GestureRecognised(Object obj);

namespace virtualRocky.librayrieGeste
{
    public static class GestureEngine
    {
        private static ICollection<Gesture> listGesture = new LinkedList<Gesture>();

        public static void testGesture(Body b)
        {
            foreach (var item in listGesture)
            {
                item.testGesture(b);
            }
        }

        public static void onGestureRecognized(Object obj, MultiSourceFrameArrivedEventArgs args)
        {
            Console.WriteLine("accroche reussi");

            var reference = args.FrameReference.AcquireFrame();
            

            using (var frame = reference.BodyFrameReference.AcquireFrame())
            {
                var bodies = new Body[frame.BodyFrameSource.BodyCount];
                if (frame != null)
                {
                    bodies = new Body[frame.BodyFrameSource.BodyCount];

                    frame.GetAndRefreshBodyData(bodies);

                    foreach (var body in bodies)
                    {
                        if (body != null)
                        {
                            if (body.IsTracked)
                            {
//                                Console.WriteLine("BODY TRACKED");
                                testGesture(body);
                            }
                        }
                    }
                }
            }

//            Console.WriteLine("Fin onGesture");
        }

        public static void ajouterGesture(Gesture gest)
        {
            listGesture.Add(gest);
            gest.GestureRegognised += testEvent; 
        }

        private static GestureRecognised gestureRegognised;
        public static event GestureRecognised GestureRegognised
        {
            add { gestureRegognised += value; }
            remove { gestureRegognised -= value; }

        }

        private static void testEvent(Object ob)
        {
            Console.WriteLine(ob.GetType());
        }
    }
}
