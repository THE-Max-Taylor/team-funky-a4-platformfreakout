using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MohawkGame2D
{


    public class Assets
    {
        public Texture2D background1;
        public void Setup()
        {
          
        }

        public void Update()
        {
        
        Vector2 textureSize = new Vector2(Window.Width,Window.Height);
        Vector2 position = new Vector2(0, 0);
        Graphics.DrawSubset(background1, position, position, textureSize);
        }   



    }
}
