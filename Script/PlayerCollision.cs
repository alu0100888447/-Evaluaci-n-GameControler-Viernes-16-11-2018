using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement playerMovement;
	public float power = 500;
	private static int contador = 0;
	public Material colorMaterial1;
	public Material colorMaterial2;

    private void Start()
    {
        GameController.IncrementPower += IncrementPower;
        GameController.DecrementPower += DecrementPower;
        GameController.EndGame += End;
		GameController.Power += MorePower;
		GameController.ChangeColor += ChangeBlockColor;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
			GameController.ChangeBlocksScale ();
			GameController.Decrement();
			GameController.MoverObjetoB ();	
			GameController.ChangeBlocksColor ();
			contador++;
        }
        if (collision.collider.tag == "NegativeObstacle")
        {
			//GameController.Increment();
			//GameController.PowerBall();
			//GameController.ColorB ();
        }
        if (collision.collider.name == "End")
        {
            GameController.End();
        }
    }

	private void MorePower () {
		power *= 1.5f;
	}

    private void IncrementPower ()
    {
        playerMovement.forwardForce += power;
    }

    private void DecrementPower ()
    {
        playerMovement.forwardForce -= power;
    }

    private void End ()
    {
        playerMovement.enabled = false;
    }

	private void ChangeBlockColor ()
	{
		if (contador % 2 == 0)
		{
			gameObject.GetComponent<Renderer>().material = colorMaterial2;
		}
		else
		{
			gameObject.GetComponent<Renderer>().material = colorMaterial1;
		}
	}
}
