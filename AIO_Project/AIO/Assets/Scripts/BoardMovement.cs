using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardMovement : MonoBehaviour {
    Vector3 playerPos;
    Vector3 startPos;
    Vector3 randomPos;
    public Transform destination;
    GameObject key;


    GameObject[] hazards;
    GameObject[] blocks;
    bool getKey;

    public TextMesh playerMessage;


    void Start () {

        playerPos = transform.position;
        startPos = playerPos;
        getKey = false;

        hazards = GameObject.FindGameObjectsWithTag("Hazard");
        blocks = GameObject.FindGameObjectsWithTag("Block");
        key = GameObject.FindGameObjectWithTag("Key");

    }
	

	void Update () {

        Vector3 newPos = playerPos;
        randomPos.x = Random.Range(0, 8);
        randomPos.z = Random.Range(0, 11);

        if (Input.GetKeyDown(KeyCode.W))
        {

            newPos = playerPos + transform.forward;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {

            newPos = playerPos - transform.forward;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {

            newPos = playerPos + transform.right;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {

            newPos = playerPos - transform.right;
        }


        bool inABlock = false;


        for (int i = 0; i < blocks.Length; i++)
        {	

            if (newPos.x == blocks[i].transform.position.x &&
                newPos.z == blocks[i].transform.position.z)
            {

                inABlock = true;
            }
        }

        if (!inABlock) {
        	playerPos = newPos;
        }



       for (int i = 0; i < hazards.Length; i++){

            if (playerPos.x == hazards[i].transform.position.x &&
                    playerPos.z == hazards[i].transform.position.z)
            {

                playerPos = randomPos;
                getKey = false;
                playerMessage.text = "Location Change!And You loss key";
            }
        }


        if (playerPos.x == key.transform.position.x && 
            playerPos.z == key.transform.position.z)
        {
            getKey = true;
            playerMessage.text = "For the win!";

        }
     
        if (playerPos.x == destination.position.x && 
            playerPos.z == destination.position.z){
            if (!getKey)
            {
                playerMessage.text = "Find the Key then go back";
            }

            if (getKey)
            {
                playerMessage.text = "you win";
            }

        }

        transform.position = playerPos;
    }
}
