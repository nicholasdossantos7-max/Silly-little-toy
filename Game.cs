// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using System.Security.Principal;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class! Like Floats and shit
    /// </summary>
    //float x;
    //float y;
    //float radius;
    //float angleform;
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        Bubble[] bubbles = new Bubble[1000];
        int bubblecount = 0;
        public void Setup()
        {
            Window.SetTitle("Interactive BUBBLES");
            Window.SetSize(800, 800);
           //Window.TargetFPS = 60;
        }


        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        /// MY PLAN FOR THIS TOY ASSIGNMENT IS AN INFINITE BUBBLE POPPING GAME. MAKE THE BUBBLES MOVES AROUND THE WINDOW, CLICK TO POP THEM
        /// AND HOLD SOMETHING LIKE SPACE TO BLOW MORE BUBBLES 
        public void Update()
        {
            Window.ClearBackground(166, 221, 255);

            if (Input.IsKeyboardKeyDown(KeyboardKey.Space))
            {
                bubbles[bubblecount] = new Bubble();
                bubbles[bubblecount].setup();
                bubblecount += 1;
            }
            
            for (int i = 0; i < bubblecount; i++)
            {
                    
                    bubbles[i].update();
            }
            if (Input.IsMouseButtonPressed(MouseButton.Left))
            {
                Vector2 mouse = Input.GetMousePosition();

                for (int i = 0; i < bubblecount; i++)
                {
                    if (bubbles[i].trypop(mouse.X, mouse.Y))
                    {
                        bubbles[i] = new Bubble();
                    }
                }

            }
            //Bubble Wand
            Draw.SetFillColor(25, 24, 28);
            Draw.Capsule(400, 800, 400, 700, 10);
            Draw.SetFillColor(25, 24, 28);
            Draw.Circle(400, 600, 100);
            Draw.SetFillColor(0, 200, 255);
            Draw.Circle(400, 600, 90);
        }

    }

}
