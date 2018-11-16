using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObstacle: MonoBehaviour {

    public float increase = 1.2f;
	private static int contador = 0;
	public Material colorMaterial;

    private void Start()
    {
        GameController.ChangeScale += increaseScale;
		//GameController.ColorTypeB += changeColor;
    }

    private void increaseScale () {
		gameObject.GetComponent<Transform> ().localScale *= increase;
	}

	private void changeColor () {
		if (contador % 2 == 0)
		{
			gameObject.GetComponent<Renderer>().material.color = new UnityEngine.Color(0, 0, 0);
		}
		else
		{
			gameObject.GetComponent<Renderer>().material = colorMaterial;
		}
	}
}
