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
        private Settings settings;

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
            this.settings = new Settings();
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

        // Sets the volume setting for background music to the given value
        public void setBackgroundMusicVolume(double volume)
        {
            this.settings.setBackgroundMusicVolume(volume);
        }

        // Returns the volume setting for background music
        public double GetBackgroundMusicVolume()
        {
            return this.settings.GetBackgroundMusicVolume();
        }
    }
}
