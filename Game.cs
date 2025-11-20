// Include the namespaces (code libraries) you need below.
//using GAME_10003_Game_Development_Foundations___2D_Game_Template__v1._4_1.MohawkGame2D;
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
        Player joePlayer = new Player();
        Cube cubes = new Cube();
        LevelOne levelOne = new LevelOne();
        //Enemy enemies = new Enemy();
        


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
            Window.ClearBackground(Color.Green);
            levelOne.update();           
            player.Update(cubes.getDetection());
            cubes.Update(player.HasPresent());
            //enemies.update();
            
        {
            Window.ClearBackground(Color.White);
            
            cubes.Update(player.HasPresent());

          
            if(player.GetLives() == 14) { 
                player.GetDirection();
                level2.Update(player.FeetCollision());
            }
            
            
            player.Update(cubes.getDetection(), level2.GetDetection());

            if (player.GetLives() <= 0) { gameOverScreen.Update(); }
        }


    }

}
