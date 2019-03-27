using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBeam : MonoBehaviour {
    public float bm;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();
        Debug.DrawRay(laser.direction, laser.direction, Color.green);
        if (Physics.Raycast(laser,out hit,100000f)){
            if(hit.rigidbody & Input.GetMouseButtonDown(0)){
                hit.rigidbody.AddForce(Random.insideUnitSphere * bm);
            }
            //Destroy(gameObject);
            Debug.Log("hit..."+ hit.transform.gameObject.name);
        }
	}
}
