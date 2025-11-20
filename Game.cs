// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Player player = new Player();
        Cube cubes = new Cube();


        Level2 level2 = new Level2();

        //Game over screen when the player dies
        GameOver gameOverScreen = new GameOver();

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(1100, 800);
            Window.SetTitle("Home Alone 7");
            player.Setup();
            cubes.Setup();
            gameOverScreen.Setup();

            level2.Setup();
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.White);
            player.Update(cubes.getDetection());
            cubes.Update(player.HasPresent());

            if(player.GetLives() <= 0) {gameOverScreen.Update();}
            if(player.GetLives() == 14) { 
                player.GetDirection();
                level2.Update();
            }
        }
    }

}
