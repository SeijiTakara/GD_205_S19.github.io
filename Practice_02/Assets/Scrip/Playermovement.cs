using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour {
    Vector3 playerPos;
    // Use this for initialization
    void Start () {
        playerPos = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 newPos = playerPos;
        if (Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.UpArrow))
        {

            newPos = playerPos + transform.forward;
        }
        if (Input.GetKeyDown(KeyCode.S)||Input.GetKeyDown(KeyCode.DownArrow))
        {

            newPos = playerPos - transform.forward;
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {

            newPos = playerPos + transform.right;
        }
        if (Input.GetKeyDown(KeyCode.A )||Input.GetKeyDown(KeyCode.LeftArrow))
        {

            newPos = playerPos - transform.right;
        }
        transform.position = playerPos;
    }
}
