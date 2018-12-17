using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField]
    private GameObject pauseMenu;

    [SerializeField]
    private GameObject instructions;

    [SerializeField]
    private GameObject settings;

    // Start is called before the first frame update
    void Start()
    {
           
    }

    // switches to the next scene to begin the game
    public void StartGame()
    {
        // load scene to start game
    }

    // shows the GameObject displaying the instructions
    public void ShowInstructions()
    {
        instructions.SetActive(true);
    }

    // hides the GameObject displaying the instructions
    public void HideInstructions()
    {
        instructions.SetActive(false);
    }

    // shows the GameObject displaying the settings
    public void ShowSettings()
    {
        settings.SetActive(true);
    }

    // hides the GameObject displaying the settings
    public void HideSettings()
    {
        settings.SetActive(false);
    }

    // terminates the application
    public void QuitGame()
    {
        Application.Quit();
    }
}
