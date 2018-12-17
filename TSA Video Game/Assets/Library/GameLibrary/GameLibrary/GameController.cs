using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary
{
    public enum GameState { MainMenu, GamePlay, Paused, Leaderboard }

    public class GameController
    {
        private static GameController gameController;

        public static GameController GetGameController()
        {
            if (GameController.gameController == null)
            {
                GameController.gameController = new GameController();
            }
            return GameController.gameController;
        }

        private GameController()
        {
            
        }

    }
}
