using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CLICK : MonoBehaviour {
    public GameObject ballFall;

    public void shooting(){
        ballFall.GetComponent<Rigidbody>().AddForce(Vector3.up * 200f);

    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
