using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
    
{
    public GameObject Enemy;
    
    public float power;

   

    void onTriggerEnter(Collider collider)
    {
        Enemy.GetComponent<Rigidbody>().AddForce(0,0,power,ForceMode.Impulse);
    }
}
