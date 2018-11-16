using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public delegate void BallGame();
    public static event BallGame ChangeColor;
    public static event BallGame ChangeScale;
    public static event BallGame BallForceD;
    public static event BallGame BallForceA;
    public static event BallGame IncrementPower;
    public static event BallGame DecrementPower;
    public static event BallGame EndGame;
    public static event BallGame TurnOn;
    public static event BallGame TurnOff;
    public static event BallGame ScoreUI;
    public static event BallGame CompleteLevel;
    public static event BallGame FollowP;
	public static event BallGame Power;
	//public static event BallGame ColorTypeB;
	public static event BallGame Mover;
	public static event BallGame Counter;

	public delegate void ColorB(Color color);
	public static event ColorB ColorTypeB;

	public Material color;
	public float masa = 1;

	void Start () {
		//InvokeRepeating ("LanzarCubo", Time.deltaTime, 2);
	}

    public static void ChangeBlocksColor ()
    {
        if (ChangeColor != null)
        {
            ChangeColor();
        }
    }

    public static void ChangeBlocksScale()
    {
        if (ChangeScale != null)
        {
            ChangeScale();
        }
    }

    public static void Increment ()
    {
        if (IncrementPower != null)
        {
            IncrementPower();
        }
    }

    public static void Decrement ()
    {
        if (DecrementPower != null)
        {
            DecrementPower();
        }
    }

    public static void End ()
    {
        if (EndGame != null)
        {
            EndGame();
        }
    }

    public static void Complete ()
    {
        if (CompleteLevel != null)
        {
            CompleteLevel();
        }
    }

	public static void PowerBall ()
	{
		if (Power != null) 
		{
			Power ();
		}
	}

/*	public static void ColorB () 
	{
		if (ColorTypeB != null) 
		{
			ColorTypeB ();
		}
	}*/

	public static void MoverObjetoB ()
	{
		if (Mover != null) 
		{
			Mover ();
		}
	}

    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            if (BallForceD != null)
            {
                BallForceD();
            }
        }
        if (Input.GetKey("a"))
        {
            if (BallForceA != null)
            {
                BallForceA();
            }
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
           if (TurnOn != null)
            {
                TurnOn();
            }
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            if (TurnOff != null)
            {
                TurnOff();
            }
        }
        if (!FindObjectOfType<GameManager>().gameHasEnd)
        {
            if (ScoreUI != null)
            {
                ScoreUI();
            }
        }
        if (FollowP != null)
        {
            FollowP();
        }
    }

    public void OnMouseDown()
    {
		if (ColorTypeB != null) 
		{
			ColorTypeB (new Color(Random.value, Random.value, Random.value));
		}
    }

	/*void LanzarCubo () {
		GameObject cubo = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cubo.AddComponent<Rigidbody> ();
		Vector3 inicio = GameObject.Find ("Player").GetComponent<Transform> ().position;
		cubo.transform.position = inicio + Vector3.right * 8;
		cubo.GetComponent<Renderer> ().material = color;
		cubo.tag = "ObstacleA";
		cubo.GetComponent<Rigidbody> ().isKinematic = true;
		cubo.AddComponent<MoverC> ();
	}*/
}
