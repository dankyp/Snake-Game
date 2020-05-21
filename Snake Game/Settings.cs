using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Game
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };
        class Settings
    {
        public static int Height { get; set; }
        public static int Width { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int Points { get; set; }
        public static bool GameOver { get; set; }
        public static Direction direction { get; set; }

        public Settings()
        {
            Height = 16;
            Width = 16;
            Speed = 16;
            Score = 0;
            Points = 100;
            direction = Direction.Down; 
        }

    }
}
