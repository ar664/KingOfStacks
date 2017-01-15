using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StackScript : MonoBehaviour {

    public GameObject Stack;

    List<GameObject> StackList = new List<GameObject>();

	// Use this for initialization
	void Start () {
        StackList.Add(gameObject);
	}
	
    void onCollisionEnter (Collision col)
    {
        if(col.gameObject.Equals(Stack))
        {
            gameObject.GetComponent<Rigidbody>().freezeRotation = true;
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            // Add To List

        }
    }

	// Update is called once per frame
	void Update () {

	}
}
