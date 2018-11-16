using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLight : MonoBehaviour {


    private void Start()
    {
        GameController.TurnOn += TurnOn;
        GameController.TurnOff += TurnOff;
    }


    public void TurnOn ()
    {
        gameObject.GetComponent<Light>().enabled = true;
    }

    public void TurnOff ()
    {
        gameObject.GetComponent<Light>().enabled = false;
    }
}
