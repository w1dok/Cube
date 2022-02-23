using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Media3D;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Diagnostics;
using System.Windows;
using System.Threading;
using System.IO;

namespace cube
{
    public class RubikCube : Cube
    {
        /// <summary>
        ///  The cube will be size x sixe x size
        /// </summary>
        private int size;

        private Point3D origin;

        /// <summary>
        /// Lenght of the cube edge
        /// </summary>
        private double edge_len;
        
        /// <summary>
        /// Space between the cubes forming the bigger cube
        /// </summary>
        private double space;

        public Cube2D projection;


    }
     
}
