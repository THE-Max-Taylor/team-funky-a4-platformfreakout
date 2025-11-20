//using GAME_10003_Game_Development_Foundations___2D_Game_Template__v1._4_1.MohawkGame2D;
using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Level1
    {
        public Vector2 badRectSize = new Vector2(100, 200);
        public Vector2 badRectPos = new Vector2(0, 600);
        Vector2 exitSize = new Vector2(100, 100);
        Vector2 exitPos = new Vector2(800, 350);
        Texture2D textureYay;
        Presents presentsYay = new Presents();
        bool onPit = false;


        public void Setup()
        {
            textureYay = Graphics.LoadTexture("MohawkGame2D\\Images\\Lava.png");
           
        }

        public void Update(Vector2 feetPosition)
        {
            
            //the obstacles
            Draw.LineColor = Color.Yellow;
            Draw.FillColor = Color.Yellow;
            Draw.Rectangle(badRectPos.X, badRectPos.Y, badRectSize.X-50, badRectSize.Y);
            Draw.Rectangle(badRectPos.X, badRectPos.Y-150, badRectSize.X-50, badRectSize.Y);
            Draw.Rectangle(badRectPos.X+180, badRectPos.Y + 140, badRectSize.X + 1000, badRectSize.Y-130);                       
            Draw.Rectangle(badRectPos.X + 250, badRectPos.Y - 30, badRectSize.X + 300, badRectSize.Y - 130);
            Draw.Rectangle(badRectPos.X + 770, badRectPos.Y - 30, badRectSize.X + 300, badRectSize.Y - 130);

            Draw.Rectangle(badRectPos.X + 500, badRectPos.Y - 550, badRectSize.X+200, badRectSize.Y);

            Draw.Rectangle(badRectPos.X + 900, badRectPos.Y - 650, badRectSize.X, badRectSize.Y+40);
            Draw.Rectangle(badRectPos.X, badRectPos.Y-600, badRectSize.X - 50, badRectSize.Y);
            Draw.Rectangle(badRectPos.X, badRectPos.Y-600, badRectSize.X + 150, badRectSize.Y-150);
            Draw.Rectangle(badRectPos.X+200, badRectPos.Y - 600, badRectSize.X, badRectSize.Y + 150);

            Graphics.Draw(textureYay, badRectPos.X, badRectPos.Y);

            //exit code
            Draw.FillColor = Color.White;
            Draw.Rectangle(exitPos, exitSize);

            //draw the presents!!
            presentsYay.update();
           
            //Graphics.Draw(textureYay, );

            //compute collision for obstacles
            float leftEdge1 = badRectPos.X + 500;
            float rightEdge1 = (badRectPos.X + 500) + (badRectSize.X + 200);
            float topEdge1 = (badRectPos.Y - 550);
            float bottomEdge1 = (badRectPos.Y - 550) + badRectSize.Y - 120;
            Console.WriteLine(badRectSize.Y);
            float playerEdge = feetPosition.X;
            float playerRightEdge = feetPosition.X + 100;
            float playerTop = feetPosition.Y;
            float playerBottom = feetPosition.Y + 60;

            bool doesOverlapLeft = leftEdge1 < playerRightEdge;
            bool doesOverlapRight = rightEdge1 > playerEdge;
            bool doesOverlapTop = topEdge1 < playerBottom;
            bool doesOverlapBottom = bottomEdge1 > playerTop;

            bool doesOverlap = doesOverlapLeft && doesOverlapRight && doesOverlapTop && doesOverlapBottom;
            if (doesOverlap)
            {
                onPit = true;
            }



        }

                public bool GetDetection()
        {
            return onPit;
        }
    }
}
