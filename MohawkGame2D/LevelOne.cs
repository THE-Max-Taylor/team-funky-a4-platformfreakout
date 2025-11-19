using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class LevelOne
    {
        Vector2 badRectSize = new Vector2(100, 200);
        Vector2 badRectPos = new Vector2(0, 600);
        Texture2D texture;

        
           

        public void update()
        {
            texture = Graphics.LoadTexture("MohawkGame2D\\Images\\Screenshot 2025-11-16 230008.png");
            Draw.LineColor = Color.Yellow;
            Draw.FillColor = Color.Yellow;
            Draw.Rectangle(badRectPos.X, badRectPos.Y, badRectSize.X-50, badRectSize.Y);
            Draw.Rectangle(badRectPos.X, badRectPos.Y-150, badRectSize.X-50, badRectSize.Y);
            Draw.Rectangle(badRectPos.X+180, badRectPos.Y + 140, badRectSize.X + 1000, badRectSize.Y-130);
            Draw.Rectangle(badRectPos.X + 180, badRectPos.Y + 140, badRectSize.X + 1000, badRectSize.Y - 130);
            Draw.Rectangle(badRectPos.X + 210, badRectPos.Y - 30, badRectSize.X + 1000, badRectSize.Y - 100);
            Draw.Rectangle(badRectPos.X + 250, badRectPos.Y - 30, badRectSize.X + 1000, badRectSize.Y - 130);
            Draw.Rectangle(badRectPos.X + 500, badRectPos.Y - 550, badRectSize.X+200, badRectSize.Y);
            Draw.Rectangle(badRectPos.X + 900, badRectPos.Y - 650, badRectSize.X, badRectSize.Y+40);
            Draw.Rectangle(badRectPos.X, badRectPos.Y-600, badRectSize.X - 50, badRectSize.Y);
            Draw.Rectangle(badRectPos.X, badRectPos.Y-600, badRectSize.X + 150, badRectSize.Y-150);
        }
    }
}
