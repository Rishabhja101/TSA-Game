using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroSceneController : MonoBehaviour
{
    [SerializeField]
    private float timeDelay;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("NextScene", timeDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Loads the next scene
    private void NextScene()
    {
        SceneManager.LoadScene("Level1"); // add scene name of first level
    }
}
