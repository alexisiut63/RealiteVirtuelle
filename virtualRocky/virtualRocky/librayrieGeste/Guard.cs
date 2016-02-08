﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Kinect;
using Microsoft.Kinect.Fusion;

namespace virtualRocky.librayrieGeste
{
    class Guard : Posture
    {
        public override bool testPosture(Body b)
        {
            Joint handR = b.Joints[JointType.HandRight];
            Joint handL = b.Joints[JointType.HandRight];
            Joint shoulderR = b.Joints[JointType.HandRight];
            Joint shoulderL= b.Joints[JointType.HandRight];


            Vector3  mainD= new Vector3();
            mainD.X = handR.Position.X;
            mainD.Y = handR.Position.Y;
            mainD.Z = handR.Position.Z;

            Vector3 mainG = new Vector3();
            mainG.X = handL.Position.X;
            mainG.Y = handL.Position.Y;
            mainG.Z = handL.Position.Z;

            Vector3 epauleD= new Vector3();
            epauleD.X = shoulderR.Position.X;
            epauleD.Y = shoulderR.Position.Y;
            epauleD.Z = shoulderR.Position.Z;

            Vector3 epauleG = new Vector3();
            epauleG.X = shoulderL.Position.X;
            epauleG.Y = shoulderL.Position.Y;
            epauleG.Z = shoulderL.Position.Z;

            // soustraction de epaule droite a epaule gauche pour nb positif
            float mains = mainD.X - mainG.X;
            if (mains > 15)
                throw new Exception("mains trop loin");

            float epmainsG = mainG.X - epauleG.X;
            float epmainsD = epauleD.X - mainD.X;

            

            return true;
        }
    }
}
