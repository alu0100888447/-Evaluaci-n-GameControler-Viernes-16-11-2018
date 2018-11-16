using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour {

    private void Start()
    {
        GameController.CompleteLevel += LevelComplete;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            GameController.Complete();
        }
    }

    private void LevelComplete ()
    {
        FindObjectOfType<GameManager>().CompleteLevel();
    }
}
