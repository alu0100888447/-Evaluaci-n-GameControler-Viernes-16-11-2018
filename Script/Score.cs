using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public float offset;
    public Text scoreText;

    private void Start()
    {
        offset = player.position.x;
        GameController.ScoreUI += ShowScore;
    }

    private void ShowScore ()
    {
        float aux = player.position.x - offset;
        scoreText.text = aux.ToString("0");
    }

}
