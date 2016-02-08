using Microsoft.Kinect;
using Rokinect.metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualRocky
{
    class Program
    {
        static void Main(string[] args)
        {
            var kinectSensor = KinectSensor.GetDefault();

            // get the coordinate mapper
            var coordinateMapper = kinectSensor.CoordinateMapper;

            // get the depth (display) extents
            FrameDescription frameDescription = kinectSensor.DepthFrameSource.FrameDescription;

            // get size of joint space
            var displayWidth = frameDescription.Width;
            var displayHeight = frameDescription.Height;

            // open the reader for the body frames
            var bodyFrameReader = kinectSensor.BodyFrameSource.OpenReader();


            Console.ReadKey(true);
            Console.Clear();
        }
    }
}
