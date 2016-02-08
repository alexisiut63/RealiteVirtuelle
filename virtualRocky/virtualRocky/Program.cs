using Microsoft.Kinect;
using Microsoft.Kinect.Fusion;
using Rokinect.metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using virtualRocky.librayrieGeste;

namespace virtualRocky
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  var kinectSensor = KinectSensor.GetDefault();

              // get the coordinate mapper
              var coordinateMapper = kinectSensor.CoordinateMapper;

              // get the depth (display) extents
              FrameDescription frameDescription = kinectSensor.DepthFrameSource.FrameDescription;

              // get size of joint space
              var displayWidth = frameDescription.Width;
              var displayHeight = frameDescription.Height;

              // open the reader for the body frames
              var bodyFrameReader = kinectSensor.BodyFrameSource.OpenReader();
              */
            Vector3 x = new Vector3();
            x.X = 10;

            Vector3 y = new Vector3();
            y.X = 30;

            float truc = y.X - x.X;
            Console.WriteLine(truc);
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}
