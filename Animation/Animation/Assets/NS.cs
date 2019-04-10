using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NS : MonoBehaviour
{
    public GameObject clone;
    public Vector3 respawnLocation;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Instantiate(clone, respawnLocation, Quaternion.identity);
        }
    }
}
