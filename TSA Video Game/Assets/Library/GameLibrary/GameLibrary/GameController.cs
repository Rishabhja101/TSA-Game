using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary
{
    public enum GameState { MainMenu, GamePlay, Paused, Leaderboard, IntroScene }

    public class GameController
    {
        private static GameController gameController;
        private GameState gameState;

        // returns the static instance of the GameController object
        public static GameController GetGameController()
        {
            if (GameController.gameController == null)
            {
                GameController.gameController = new GameController();
            }
            return GameController.gameController;
        }

        // initiates the GameController Object
        private GameController()
        {
            this.gameState = GameState.MainMenu;
        }

        // returns the current gamestate
        public GameState GetGameState()
        {
            return this.gameState;
        }

        // Pauses or unpauses the game
        public void TogglePauseState()
        {
            if (this.gameState == GameState.GamePlay)
            {
                this.gameState = GameState.Paused;
            }
            else if (this.gameState == GameState.Paused)
            {
                this.gameState = GameState.GamePlay;
            }
        }

        // Starts the game
        public void StartGame()
        {
            this.gameState = GameState.GamePlay;
        }

    }
}
