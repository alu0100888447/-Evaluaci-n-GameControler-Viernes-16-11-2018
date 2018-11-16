using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public Text textOver;
    public bool gameHasEnd { get; set; }
    public GameObject CompleteLevelUI;
    float delay = 5f;

    private void Start()
    {
        CompleteLevelUI.SetActive(false);
        gameHasEnd = false;
    }

    public void CompleteLevel ()
    {
        if (gameHasEnd == false)
        {
            CompleteLevelUI.SetActive(true);
            gameHasEnd = true;
            Invoke("EndScene", delay);
        }
    }

    public void EndGame ()
    {
        if (gameHasEnd == false)
        {
            gameHasEnd = true;
            textOver.text = "Game Over";
            Invoke("EndScene", delay);
        }
    }

    void EndScene()
    {
        Application.Quit();
    }
	
}
