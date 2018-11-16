using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBloque : MonoBehaviour {

    public GameObject []bloques;
    public float contador = 0;
    public Material colorMaterial;
	public Material colorMaterial2;

    private void Start()
    {
        //GameController.ChangeColor += ChangeBlockColor;
		GameController.ColorTypeB += ChangeBlockColor;
		GameController.Counter += incrementCounter;
    }


	private void Update() {
		contador += Time.deltaTime;
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Player")
        {
            GameController.ChangeBlocksColor();
            contador++;
        } 
    }

    private void ChangeBlockColor (Color color)
    {
    
		gameObject.GetComponent<Renderer>().material.color = color	;

    }

	private void incrementCounter ()
	{
		contador++;
	}

	private void changeMasa () 
	{
		gameObject.GetComponent<Rigidbody> ().mass *= 1.2f;
	}
}
