using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;

    private void Start()
    {
        GameController.FollowP += Follow;
    }

    private void Follow ()
    {
        transform.position = player.position + offset;
    }
}
