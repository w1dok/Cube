using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Media3D;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

namespace cube
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public enum Difficulty
        {
            Easy = 10,
            Normal = 20,
            Hard = 30,
            VeryHard = 40
        }

        Point startMoveCamera;
        bool allowMoveCamera = false, allowMoveLayer = false, gameOver = false;
        int size = 3;
        double edge_len = 1;
        double space = 0.05;
        double len;

        Transform3DGroup rotation = new Transform3DGroup();
        //RubikCube c;
    }
}
