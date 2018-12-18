using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GameLibrary;

public class IntroSceneController : MonoBehaviour
{
    [SerializeField]
    private float timeDelay;

    private GameController gameController;

    // Start is called before the first frame update
    private void Start()
    {
        gameController = GameController.GetGameController();
        Invoke("NextScene", timeDelay);
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    // Loads the next scene
    private void NextScene()
    {
        gameController.StartGame();
        SceneManager.LoadScene("Level1"); // add scene name of first level
    }
}
