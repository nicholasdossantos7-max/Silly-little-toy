using System;
using System.Collections.Generic;
using System.Text;

//idk if I will have to use this cs
namespace MohawkGame2D
{
    public class Bubble
    {
        float x = 400;
        float y = 600;
        float xspeed;
        float yspeed;
        float radius = 50;
        Color bubblecolor;
        public void setup()
        {
            xspeed = Random.Integer(-5,3);
            yspeed = Random.Integer(-5,3);
            
            radius = Random.Integer(10, 50);
        }

        public void update()
        {
            y += yspeed;
            x += xspeed;

            if (x > 800) xspeed = -xspeed;
            if (x < 0) xspeed = -xspeed;
            if (y > 800) yspeed = -yspeed;
            if (y < 0) yspeed = -yspeed;

            //bubble design
            Draw.SetFillColor(200, 225, 255);
            Draw.Circle(x, y, radius);
            //bubble lighting
            Draw.SetFillColor(200, 240, 255);
            Draw.SetLineSize(0);
            Draw.Circle(x, y, radius); //210, 165

            //Bubble Wand
            Draw.SetFillColor(230, 230, 255);

        }

        public bool trypop(float xbubblepop, float ybubblepop)
        {
            if ((x + radius >= xbubblepop && x - radius <= xbubblepop) && (y + radius >= ybubblepop && y - radius <= ybubblepop))
                return true;
            return false;
        }
    }
}
