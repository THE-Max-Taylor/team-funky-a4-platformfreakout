using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    internal class Player
    {
        Vector2 position = new Vector2(100, 100);
        Vector2 size;
        Vector2 feetPosition; //Used to check collision closer to legs and feet
        Vector2 feetSize = new Vector2(100, 40); //Used to check collision closer to legs and feet
        Texture2D texture;
        int score;
        int lives = 3; //How many lives the player has
        public Player() { }

        /// <summary>
        ///  Setup runs once before the game loop begins.
        /// </summary>
        public void Setup() {
            feetPosition = new Vector2(position.X, position.Y + 60); 
            texture = Graphics.LoadTexture("MohawkGame2D\\Images\\Kevin.png");
        }

        /// <summary>
        /// Update runs every frame.
        /// </summary>
        public void Update() {
            Inputs();
            Graphics.Draw(texture, position);
        }

        /// <summary>
        /// Checks for player inputs via controller or keyboard
        /// </summary>
        void Inputs(){
            float deadzone = 0.05f;
            if ((Input.IsKeyboardKeyDown(KeyboardInput.Right) == true) || (Input.GetAnyControllerAxis(ControllerAxis.LeftX, deadzone) > 0.10))
            {
                position.X += 10;

            }
            else if ((Input.IsKeyboardKeyDown(KeyboardInput.Left) == true) || (Input.GetAnyControllerAxis(ControllerAxis.LeftX, deadzone) < -0.10))
            {
                position.X -= 10;
            }
            if ((Input.IsKeyboardKeyDown(KeyboardInput.Down) == true) || (Input.GetAnyControllerAxis(ControllerAxis.LeftY, deadzone) > 0.10))
            {
                position.Y += 10;
            }
            else if ((Input.IsKeyboardKeyDown(KeyboardInput.Up) == true) || (Input.GetAnyControllerAxis(ControllerAxis.LeftY, deadzone) < -0.10))
            {
                position.Y -= 10;
            }
        }
    }
}
