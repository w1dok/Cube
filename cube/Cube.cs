using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Media3D;
using System.Windows.Media;

namespace cube
{
    /// <summary>
    /// Designates a standart naming of a cube's sides or faces
    /// </summary>
    public enum CubeFace
    {
        F, // front
        R, // right
        B, // back
        L, // left
        U, // up
        D, // down
        None
    }

    /// <summary>
    /// Create a cube
    /// 
    /// In order to distplay the cube to a <see cref="Viewport3DVisual"/>:
    /// <code>
    /// Cube c = new Cube(new Point3D(0, 0, 0), 1, new Dictionary&lt;CubeFace, Material&gt;() {
    ///     {CubeFace.F, new DiffuseMaterial(new SolidColorBrush(Colors.White))},
    ///     {CubeFace.R, new DiffuseMaterial(new SolidColorBrush(Colors.Blue))},
    ///     {CubeFace.U, new DiffuseMaterial(new SolidColorBrush(Colors.Yellow))},
    /// });
    /// 
    /// ModelVisual3D m = new ModelVisual3D();
    /// m.Content = c.group;
    /// 
    /// this.mainViewport.Children.Add(m);
    /// </code>
    /// </summary>
    public class Cube : ModelVisual3D {
        private Point3D origin;
        private double edge_len;

        private Material defaultMaterial = new DiffuseMaterial(new SolidColorBrush(Colors.Black));
        private Dictionary<CubeFace, Material> faces;
        public HashSet<Move> possibleMoves = new HashSet<Move>();
    }
     
}
