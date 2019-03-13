using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ppp : MonoBehaviour {
    Rigidbody predRB;
    public Transform prey;
    public float forceAmt;
    public float dangerDist = 20f;
	// Use this for initialization
	void Start () {
        predRB = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 preyDirection = Vector3.Normalize(prey.position - transform.position);
        if (Vector3.Distance(prey.position, transform.position) <= dangerDist)
        {
            predRB.AddForce(preyDirection * forceAmt);
        }

	}
    private void OnCollisionEnter(Collision col)
    {

    }
}
