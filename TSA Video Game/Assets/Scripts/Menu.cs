using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GameLibrary;

public class Menu : MonoBehaviour
{
    [SerializeField]
    private GameObject pauseMenu;

    [SerializeField]
    private GameObject settings;

    private GameController gameController;

    // Start is called before the first frame update
    private void Start()
    {
        gameController = GameController.GetGameController();
        if (gameController.GetGameState() == GameState.GamePlay)
        {
            HidePauseMenu();
        }
        else if (gameController.GetGameState() == GameState.MainMenu)
        {
            HideSettings();
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameController.TogglePauseState();
            if (gameController.GetGameState() == GameState.GamePlay)
            {
                ResumeGame();
            }
            else if (gameController.GetGameState() == GameState.Paused)
            {
                PauseGame();
            }
        }
    }

    // Switches to the next scene to begin the game
    public void StartGame()
    {
        SceneManager.LoadScene("IntroScene");
    }

    // Shows the GameObject displaying the settings
    public void ShowSettings()
    {
        settings.SetActive(true);
    }

    // Hides the GameObject displaying the settings
    public void HideSettings()
    {
        settings.SetActive(false);
    }

    // Shows the GameObject displaying the pause menu
    public void ShowPauseMenu()
    {
        pauseMenu.SetActive(true);
    }

    // Hides the GameObject displaying the pause menu
    public void HidePauseMenu()
    {
        pauseMenu.SetActive(false);
    }

    // Terminates the application
    public void QuitGame()
    {
        Application.Quit();
    }

    // Resumes gameplay
    public void ResumeGame()
    {
        HidePauseMenu();
        // add resume gameplay
    }

    // Pauses gameplay
    public void PauseGame()
    {
        ShowPauseMenu();
        // add pause the game
    }

    // Returns to the title menu
    public void ReturnToTitle()
    {
        SceneManager.LoadScene("TitleScreen");
    }


}
