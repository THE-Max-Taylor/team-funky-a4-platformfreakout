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

        public void update()
        {
            Draw.LineColor = Color.Yellow;
            Draw.FillColor = Color.Yellow;
            Draw.Rectangle(badRectPos.X, badRectPos.Y, badRectSize.X-50, badRectSize.Y);
            Draw.Rectangle(badRectPos.X, badRectPos.Y-150, badRectSize.X-50, badRectSize.Y);
            Draw.Rectangle(badRectPos.X+180, badRectPos.Y + 140, badRectSize.X + 1000, badRectSize.Y-130);
            Draw.Rectangle(badRectPos.X + 180, badRectPos.Y + 140, badRectSize.X + 1000, badRectSize.Y - 130);
            Draw.Rectangle(badRectPos.X + 180, badRectPos.Y - 30, badRectSize.X + 1000, badRectSize.Y - 130);




        }
    }
}
