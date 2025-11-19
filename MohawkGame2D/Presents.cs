using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GAME_10003_Game_Development_Foundations___2D_Game_Template__v1._4_1.MohawkGame2D
{
    internal class Presents
    {
        public Vector2 presentsPos = new Vector2(0, 0);
        public Vector2 presentsSize = new Vector2(50, 40);
        public void update()
        {
            Vector2 presentsPos = new Vector2(0, 0);
            Vector2 presentsSize = new Vector2(50, 40);
            Draw.FillColor = Color.Red;
            Draw.LineColor = Color.Black;
            Draw.Rectangle(presentsPos.X + 100, presentsPos.Y + 100, presentsSize.X, presentsSize.Y);
            Draw.Rectangle(presentsPos.X + 400,presentsPos.Y + 100, presentsSize.X, presentsSize.Y);
            Draw.Rectangle(presentsPos.X + 400, presentsPos.Y + 400, presentsSize.X, presentsSize.Y);
            Draw.Rectangle(presentsPos.X + 930, presentsPos.Y + 670, presentsSize.X, presentsSize.Y);
            Draw.Rectangle(presentsPos.X + 800, presentsPos.Y + 670, presentsSize.X, presentsSize.Y);
            Draw.Rectangle(presentsPos.X + 670, presentsPos.Y + 670, presentsSize.X, presentsSize.Y);
            Draw.Rectangle(presentsPos.X + 670, presentsPos.Y, presentsSize.X, presentsSize.Y);
            Draw.Rectangle(presentsPos.X + 1030, presentsPos.Y, presentsSize.X, presentsSize.Y);
            Draw.Rectangle(presentsPos.X + 160, presentsPos.Y + 550, presentsSize.X, presentsSize.Y);
            Draw.Rectangle(presentsPos.X + 950, presentsPos.Y + 500, presentsSize.X, presentsSize.Y);

        }
    }
}
