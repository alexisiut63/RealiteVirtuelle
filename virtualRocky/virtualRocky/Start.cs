using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Kinect;
using virtualRocky.librayrieGeste;

namespace virtualRocky
{
    public class Start
    {
        KinectSensor sensor;
        MultiSourceFrameReader reader;
        IList<Body> bodies;


        public Start()
        {

        }

        public void start()
        {
            sensor = KinectSensor.GetDefault();

            if (sensor != null)
            {
                sensor.Open();
                reader = sensor.OpenMultiSourceFrameReader(FrameSourceTypes.Color | FrameSourceTypes.Depth | FrameSourceTypes.Infrared | FrameSourceTypes.Body);
                reader.MultiSourceFrameArrived += GestureEngine.onGestureRecognized;
            }

        }

        public void ajouterGesture()
        {
            GestureEngine.ajouterGesture(new Guard());
        }

    }
}
