using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    internal class GameOver
    {
        Vector2[] snow = new Vector2[500];
        public GameOver() { }

  
        public void Setup(){
            for (int i = 0; i < snow.Length; i++)
            {
                snow[i].Y = Random.Integer(1, 800);
                snow[i].X = Random.Integer(1,1100);
            }
        }

        public void Update() { 
            Window.ClearBackground(Color.Black);
            Draw.FillColor = Color.White;
            Draw.LineColor = Color.White;
            Draw.Rectangle(new Vector2(0, 500), new Vector2(1100, 300));

            Draw.FillColor = Color.Gray;
            Draw.LineColor = Color.Gray;
            Draw.Rectangle(new Vector2(475, 350), new Vector2(100, 150));
            Draw.Circle(new Vector2(525, 350), 50);



            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.White;
            for (int i = 0; i < snow.Length; i++){
                snow[i].Y++;
                Draw.Circle(snow[i], 2);
                if (snow[i].Y > 800) { snow[i].Y = 0; }
            }
        }
    }
}
