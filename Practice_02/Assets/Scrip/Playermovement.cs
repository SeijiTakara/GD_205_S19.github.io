using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour {
    Vector3 playerPos;
    Rigidbody myRb;
    // Use this for initialization
    void Start () {
        playerPos = transform.position;
        myRb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 newPos = playerPos;
        if (Input.GetKey(KeyCode.W)||Input.GetKeyDown(KeyCode.UpArrow))
        {

            myRb.AddForce(Vector3.forward*32f);
        }
        if (Input.GetKey(KeyCode.S)||Input.GetKeyDown(KeyCode.DownArrow))
        {

            myRb.AddForce(Vector3.back * 32f);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {

            myRb.AddForce(Vector3.right * 32f);
        }
        if (Input.GetKey(KeyCode.A )||Input.GetKeyDown(KeyCode.LeftArrow))
        {

            myRb.AddForce(Vector3.left * 32f);
        }

    }
}
