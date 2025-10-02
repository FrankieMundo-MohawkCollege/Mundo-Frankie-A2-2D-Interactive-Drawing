// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Color Background = new(255, 192, 203); // Pink
        Color colorRed = new(255, 0, 0); // Red
        Color colorPurple = new(167, 111, 219); // Purple
        Color colorGreen = new(126, 235, 79); // Green
        int circleColor = 0;
        public void Circle()
        {
            
        }

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Frankie Mundo - Interactive 2D A2");
            Window.SetSize(600, 800);
            Window.TargetFPS = 60;
            
            
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Background);

            if (Input.IsKeyboardKeyPressed(KeyboardInput.Space))
            {

                circleColor = Random.Integer(1, 4);
            }
            if (circleColor == 1)
            {
                
                Draw.FillColor = colorRed;
            }
            else if (circleColor == 2)
            {
                
                Draw.FillColor = colorPurple;
            }
            else if (circleColor == 3)
            {
                
                Draw.FillColor = colorGreen;
            }

            for (int i = 0; i < 10; i++)
            {
                int x = i * 45 - 200;
                 Draw.Circle(x + Input.GetMouseX (), Input.GetMouseY(), 20);
            }

        }
        
    }

}
