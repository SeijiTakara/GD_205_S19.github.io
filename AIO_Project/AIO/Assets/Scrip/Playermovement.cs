using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Playermovement : MonoBehaviour {
    Vector3 playerPos;
    Rigidbody myRb;
    int chi;
    public int beichi;
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

            myRb.AddForce(Vector3.forward*16f);
        }
        if (Input.GetKey(KeyCode.S)||Input.GetKeyDown(KeyCode.DownArrow))
        {

            myRb.AddForce(Vector3.back * 16f);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {

            myRb.AddForce(Vector3.right * 16f);
        }
        if (Input.GetKey(KeyCode.A )||Input.GetKeyDown(KeyCode.LeftArrow))
        {

            myRb.AddForce(Vector3.left * 16f);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.down * 16f);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up * 16f);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRb.AddForce(Vector3.up * 406f);
        }

    }
    private void OnCollisionEnter(Collision col)
    {
        Vector3 newPos = playerPos;
        if (col.gameObject.CompareTag("prey"))
        {
            chi++;
            Destroy(col.gameObject);
            gameObject.transform.localScale += new Vector3(1, 1, 1);
            Debug.Log("chi dao le");
        }
        if (col.gameObject.CompareTag("pred"))
        {
            beichi++;
            gameObject.transform.localScale -= new Vector3(1, 1, 1);
            col.gameObject.transform.localScale += new Vector3(1, 1, 1);
            if (chi < beichi)
            {
                Destroy(gameObject);
                Debug.Log("bei chi li");

            }
        }
    }
}
