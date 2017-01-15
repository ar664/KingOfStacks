using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour {

    public Game Game;

    //Order of Actions in Turn
    // 1. Place Stack
    // 2. Move Player
    // 3. Draw Stack + Chance
    // 4. Extra

    public bool ActiveTurn = false;
    List<GameObject> Inventory = new List<GameObject>();

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
