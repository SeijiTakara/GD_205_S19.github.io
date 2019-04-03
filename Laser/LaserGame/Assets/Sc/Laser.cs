using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Laser : MonoBehaviour {
    LineRenderer bole;
   
	// Use this for initialization
	void Start () {
        bole = gameObject.GetComponent<LineRenderer>();
        bole.enabled = false;
        Screen.lockCursor = true;


		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(1))
        {
            StopCoroutine("FireLaser");
            StartCoroutine("FireLaser");
        }
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(1);
        }
        if (Input.GetKey(KeyCode.M))
        {
            Application.Quit();
        }
    }
    IEnumerator FireLaser()
    {
        bole.enabled = true;
        while(Input.GetMouseButton(1))
        {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;

            bole.SetPosition(0, ray.origin);
            if (Physics.Raycast(ray, out hit, 100))
            {
                bole.SetPosition(1, hit.point);
                if(hit.rigidbody)
                {
                    hit.rigidbody.AddForceAtPosition(transform.forward * 50, hit.point);
                }
            }

            else
                bole.SetPosition(1, ray.GetPoint(100));

            yield return null;

        }
        bole.enabled = false;

    }
}
