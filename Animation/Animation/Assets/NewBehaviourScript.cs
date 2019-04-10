﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Animator myAnim;
    // Use this for initialization
    void Start()
    {
        myAnim = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        myAnim.SetInteger("State", 0);
        if (Input.GetKeyDown(KeyCode.W))
        {
            myAnim.SetInteger("State", 1);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            myAnim.SetInteger("State", 3);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            myAnim.SetInteger("State", 2);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            myAnim.SetInteger("State", 4);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            myAnim.SetInteger("State", 5);
        }

    }
}
