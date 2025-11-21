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
        float pointsCount = 0;
        bool present1Collected = false;


        public void Setup()
        {
            textureYay = Graphics.LoadTexture("MohawkGame2D\\Images\\Lava.png");
           
        }

        public void Update(Vector2 feetPosition)
        {
            
            //the obstacles
            Draw.LineColor = Color.Yellow;
            Draw.FillColor = Color.Yellow;
            
            Draw.Rectangle(badRectPos.X + 500, badRectPos.Y - 550, badRectSize.X+200, badRectSize.Y);
            Draw.Rectangle(badRectPos.X, badRectPos.Y, badRectSize.X-50, badRectSize.Y);
            Draw.Rectangle(badRectPos.X, badRectPos.Y-150, badRectSize.X-50, badRectSize.Y);           
            Draw.Rectangle(badRectPos.X+180, badRectPos.Y + 140, badRectSize.X + 1000, badRectSize.Y-130);             
            Draw.Rectangle(badRectPos.X + 250, badRectPos.Y - 30, badRectSize.X + 300, badRectSize.Y - 130);
            Draw.Rectangle(badRectPos.X + 770, badRectPos.Y - 30, badRectSize.X + 300, badRectSize.Y - 130);
            Draw.Rectangle(badRectPos.X + 900, badRectPos.Y - 650, badRectSize.X, badRectSize.Y+40);
            Draw.Rectangle(badRectPos.X, badRectPos.Y-600, badRectSize.X - 50, badRectSize.Y);
            Draw.Rectangle(badRectPos.X, badRectPos.Y-600, badRectSize.X + 150, badRectSize.Y-150);

            Draw.Rectangle(badRectPos.X+200, badRectPos.Y - 600, badRectSize.X, badRectSize.Y + 150);

            Graphics.Draw(textureYay, badRectPos.X, badRectPos.Y);

            //exit code
            Draw.FillColor = Color.White;
            Draw.Rectangle(exitPos, exitSize);

            //draw the presents!!
            presentsYay.Update();

            //compute collision boundaries for player 
            float playerEdge = feetPosition.X;
            float playerRightEdge = feetPosition.X + 100;
            float playerTop = feetPosition.Y;
            float playerBottom = feetPosition.Y + 60;


            //compute collision boundaries for obstacle 1
            float leftEdge1 = badRectPos.X + 500;
            float rightEdge1 = (badRectPos.X + 500) + (badRectSize.X + 200);
            float topEdge1 = (badRectPos.Y - 650);
            float bottomEdge1 = (badRectPos.Y - 650) + badRectSize.Y - 30;
           
           
            //check if things are colliding
            bool doesOverlapLeft = leftEdge1 < playerRightEdge;
            bool doesOverlapRight = rightEdge1 > playerEdge;
            bool doesOverlapTop = topEdge1 < playerBottom;
            bool doesOverlapBottom = bottomEdge1 > playerTop;

            bool doesOverlap = doesOverlapLeft && doesOverlapRight && doesOverlapTop && doesOverlapBottom;
            if (doesOverlap)
            {
                Draw.FillColor = Color.Blue;
                Draw.Circle(20, 20, 50);
                //onPit = true;
            }

            //compute collision for obstacle 2
            leftEdge1 = badRectPos.X;
            rightEdge1 = (badRectPos.X) + (badRectSize.X - 50);
            topEdge1 = (badRectPos.Y - 150);
            bottomEdge1 = (badRectPos.Y) + badRectSize.Y;

            doesOverlapLeft = leftEdge1 < playerRightEdge;
            doesOverlapRight = rightEdge1 > playerEdge;
            doesOverlapTop = topEdge1 < playerBottom;
            doesOverlapBottom = bottomEdge1 > playerTop;

            doesOverlap = doesOverlapLeft && doesOverlapRight && doesOverlapTop && doesOverlapBottom;
            if (doesOverlap)
            {
                Draw.FillColor = Color.Blue;
                Draw.Circle(20, 20, 50);
                //onPit = true;
            }

            //compute collision for obstacle 3
            leftEdge1 = badRectPos.X;
            rightEdge1 = (badRectPos.X) + (badRectSize.X - 50);
            topEdge1 = (badRectPos.Y - 220);
            bottomEdge1 = (badRectPos.Y - 220) + badRectSize.Y;

            doesOverlapLeft = leftEdge1 < playerRightEdge;
            doesOverlapRight = rightEdge1 > playerEdge;
            doesOverlapTop = topEdge1 < playerBottom;
            doesOverlapBottom = bottomEdge1 > playerTop;

            doesOverlap = doesOverlapLeft && doesOverlapRight && doesOverlapTop && doesOverlapBottom;
            if (doesOverlap)
            {
                Draw.FillColor = Color.Blue;
                Draw.Circle(20, 20, 50);
                //onPit = true;
            }

            //compute collision for obstacle 4           
            leftEdge1 = badRectPos.X + 180;
            rightEdge1 = (badRectPos.X + 180) + (badRectSize.X + 1000);
            topEdge1 = (badRectPos.Y+50);
            bottomEdge1 = (badRectPos.Y+50) + badRectSize.Y - 130;

            doesOverlapLeft = leftEdge1 < playerRightEdge;
            doesOverlapRight = rightEdge1 > playerEdge;
            doesOverlapTop = topEdge1 < playerBottom;
            doesOverlapBottom = bottomEdge1 > playerTop;

            doesOverlap = doesOverlapLeft && doesOverlapRight && doesOverlapTop && doesOverlapBottom;
            if (doesOverlap)
            {
                Draw.FillColor = Color.Blue;
                Draw.Circle(20, 20, 50);
                //onPit = true;
            }

            //compute collision for obstacle 5
            leftEdge1 = badRectPos.X + 250;
            rightEdge1 = (badRectPos.X + 250) + (badRectSize.X + 290);
            topEdge1 = (badRectPos.Y - 130);
            bottomEdge1 = (badRectPos.Y - 130) + badRectSize.Y - 150;


            doesOverlapLeft = leftEdge1 < playerRightEdge;
            doesOverlapRight = rightEdge1 > playerEdge;
            doesOverlapTop = topEdge1 < playerBottom;
            doesOverlapBottom = bottomEdge1 > playerTop;

            doesOverlap = doesOverlapLeft && doesOverlapRight && doesOverlapTop && doesOverlapBottom;
            if (doesOverlap)
            {
                Draw.FillColor = Color.Blue;
                Draw.Circle(20, 20, 50);
                //onPit = true;
            }

            //compute collision for obstacle 6          
            leftEdge1 = badRectPos.X + 770;
            rightEdge1 = (badRectPos.X + 770) + (badRectSize.X + 300);
            topEdge1 = (badRectPos.Y - 130);
            bottomEdge1 = (badRectPos.Y - 130) + badRectSize.Y - 160;

            doesOverlapLeft = leftEdge1 < playerRightEdge;
            doesOverlapRight = rightEdge1 > playerEdge;
            doesOverlapTop = topEdge1 < playerBottom;
            doesOverlapBottom = bottomEdge1 > playerTop;

            doesOverlap = doesOverlapLeft && doesOverlapRight && doesOverlapTop && doesOverlapBottom;
            if (doesOverlap)
            {
                Draw.FillColor = Color.Blue;
                Draw.Circle(20, 20, 50);
                //onPit = true;
            }

            
            //compute collision for obstacle 7
            leftEdge1 = badRectPos.X + 900;
            rightEdge1 = (badRectPos.X + 900) + (badRectSize.X + 15);
            topEdge1 = (badRectPos.Y - 730);
            bottomEdge1 = (badRectPos.Y - 730) + badRectSize.Y;

            doesOverlapLeft = leftEdge1 < playerRightEdge;
            doesOverlapRight = rightEdge1 > playerEdge;
            doesOverlapTop = topEdge1 < playerBottom;
            doesOverlapBottom = bottomEdge1 > playerTop;

            doesOverlap = doesOverlapLeft && doesOverlapRight && doesOverlapTop && doesOverlapBottom;
            if (doesOverlap)
            {
                Draw.FillColor = Color.Blue;
                Draw.Circle(20, 20, 50);
                //onPit = true;
            }

            //compute collision for obstacle 8
            leftEdge1 = badRectPos.X;
            rightEdge1 = (badRectPos.X) + (badRectSize.X - 50);
            topEdge1 = (badRectPos.Y - 715);
            bottomEdge1 = (badRectPos.Y - 715) + badRectSize.Y;

            doesOverlapLeft = leftEdge1 < playerRightEdge;
            doesOverlapRight = rightEdge1 > playerEdge;
            doesOverlapTop = topEdge1 < playerBottom;
            doesOverlapBottom = bottomEdge1 > playerTop;

            doesOverlap = doesOverlapLeft && doesOverlapRight && doesOverlapTop && doesOverlapBottom;
            if (doesOverlap)
            {
                Draw.FillColor = Color.Blue;
                Draw.Circle(20, 20, 50);
                //onPit = true;
            }

                //compute collision for obstacle 9               
                leftEdge1 = badRectPos.X;
                rightEdge1 = (badRectPos.X) + (badRectSize.X + 150);
                topEdge1 = (badRectPos.Y - 700);
                bottomEdge1 = (badRectPos.Y - 700) + badRectSize.Y - 150;

                doesOverlapLeft = leftEdge1 < playerRightEdge;
                doesOverlapRight = rightEdge1 > playerEdge;
                doesOverlapTop = topEdge1 < playerBottom;
                doesOverlapBottom = bottomEdge1 > playerTop;

                doesOverlap = doesOverlapLeft && doesOverlapRight && doesOverlapTop && doesOverlapBottom;
                if (doesOverlap)
                {
                    Draw.FillColor = Color.Blue;
                    Draw.Circle(20, 20, 50);
                    //onPit = true;
                }
            
            //compute collision for obstacle 10        
            leftEdge1 = badRectPos.X + 200;
            rightEdge1 = (badRectPos.X + 200) + (badRectSize.X);
            topEdge1 = (badRectPos.Y - 700);
            bottomEdge1 = (badRectPos.Y - 700) + badRectSize.Y + 150;

            doesOverlapLeft = leftEdge1 < playerRightEdge;
            doesOverlapRight = rightEdge1 > playerEdge;
            doesOverlapTop = topEdge1 < playerBottom;
            doesOverlapBottom = bottomEdge1 > playerTop;

            doesOverlap = doesOverlapLeft && doesOverlapRight && doesOverlapTop && doesOverlapBottom;
            if (doesOverlap)
            {
                Draw.FillColor = Color.Blue;
                Draw.Circle(20, 20, 50);
                //onPit = true;
            }


            // presents collision
            
            //present #1
            float presentsEdge = presentsYay.presentsPos.X + 100;
            float presentsRightEdge = (presentsYay.presentsPos.X + 100) + (presentsYay.presentsSize.X);
            float presentsTopEdge = (presentsYay.presentsPos.Y);
            float presentsBottomEdge = (presentsYay.presentsPos.Y) + presentsYay.presentsSize.Y;

            bool presentOverlapLeft = presentsEdge < playerRightEdge;
            bool presentOverlapRight = presentsRightEdge > playerEdge;
            bool presentOverlapTop = presentsTopEdge < playerBottom;
            bool presentOverlapBottom = presentsBottomEdge > playerTop;

            bool doesPresentOverlap = presentOverlapLeft && presentOverlapRight && presentOverlapTop && presentOverlapBottom;
            if (doesPresentOverlap)               
            {
                          
                Console.WriteLine($"collected? {present1Collected}");
                Draw.FillColor = Color.Green;
                Draw.Rectangle(presentsYay.presentsPos.X + 100, presentsYay.presentsPos.Y + 100, presentsYay.presentsSize.X, presentsYay.presentsSize.Y);
                present1Collected = true;                                                                       
            }           

            //present #2
            //presentsPos.X + 400, presentsPos.Y + 100, presentsSize.X, presentsSize.Y
            presentsEdge = presentsYay.presentsPos.X + 400;
            presentsRightEdge = (presentsYay.presentsPos.X + 400) + (presentsYay.presentsSize.X);
            presentsTopEdge = (presentsYay.presentsPos.Y);
            presentsBottomEdge = (presentsYay.presentsPos.Y) + presentsYay.presentsSize.Y;

            presentOverlapLeft = presentsEdge < playerRightEdge;
            presentOverlapRight = presentsRightEdge > playerEdge;
            presentOverlapTop = presentsTopEdge < playerBottom;
            presentOverlapBottom = presentsBottomEdge > playerTop;

            doesPresentOverlap = presentOverlapLeft && presentOverlapRight && presentOverlapTop && presentOverlapBottom;
            if (doesPresentOverlap)
            {                               
                Draw.LineColor = Color.Green;
                Draw.FillColor = Color.Green;
                Draw.Rectangle(presentsYay.presentsPos.X + 400, presentsYay.presentsPos.Y + 100, presentsYay.presentsSize.X, presentsYay.presentsSize.Y);             
               
            }

        }

                public bool GetDetection()
                 {
                    return onPit;
                }
    }
}
