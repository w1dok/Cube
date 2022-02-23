using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace cube
{
    public class Cube2D
    {
        private int size;
        public CubeFace[,] projection { get; private set; }

        public Cube2D(int size)
        {
            this.size = size;
            this.projection = new CubeFace[size*4, size*3];
            createCube();
        }

        private void createCube()
        {
            for (int i = 0; i < size*4; i++)
            {
                for (int j = 0; j < size * 3; j++)
                {
                    if (i < size && j >= size && j < size * 2)
                        projection[i, j] = CubeFace.B;
                    else if (i >= size && i < size * 2)
                    {
                        if (j < size)
                            projection[i, j] = CubeFace.L;

                        else if (j >= size && j < size * 2)
                            projection[i, j] = CubeFace.D;
                        else
                            projection[i, j] = CubeFace.R;
                    }
                    else if (i > size * 2 && i < size * 3 && j >= size && j < size * 2)
                        projection[i, j] = CubeFace.F;
                    else if (i >= size * 3 && j >= size && j < size * 2)
                        projection[i, j] = CubeFace.U;
                    else
                        projection[i, j] = CubeFace.None;
                }
            }
        }

        public void rotate(KeyValuePair<Move, RotationDirection> move)
        {
            switch (move.Ket)
            {
                case Move.F:
                case Move.S:
                    rotateFS(move.Key, move.Value);
                    break;
            }
        }







        private void rotateR(RotationDirection d)
        {
            CubeFace t;
            int j = 5;

            List<List<int>> substitution = new List<List<int>>
            {
                new List<int> {3, 8, 5, 8},
                new List<int> {5, 8, 5, 6},
                new List<int> {5, 6, 3, 6},
                new List<int> {3, 6, 3, 8},
                new List<int> {5, 7, 4, 6},
                new List<int> {4, 6, 3, 7},
                new List<int> {3, 7, 4, 8},
                new List<int> {4, 8, 5, 7},
            };
        }
    }
}
