using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverC : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameController.Mover += movimiento;
	}
	
	private void movimiento () {
		Debug.Log (gameObject.GetComponent<Transform> ().position);
		gameObject.GetComponent<Transform> ().Translate((Vector3.right * GameObject.Find ("Player").GetComponent<PlayerCollision> ().power / 100));
		//gameObject.GetComponent<Rigidbody>().AddForce(GameObject.Find ("Player").GetComponent<PlayerCollision> ().power / 100 * Time.deltaTime, 0, 0);
	}
}
