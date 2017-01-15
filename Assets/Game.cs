using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Game : MonoBehaviour {

    public Player Player;

	// Use this for initialization
	void Start () {
        InitPlayers();
        
	}
	
	// Update is called once per frame
	void Update () {

	}

    void InitPlayers()
    {
        Player.ActiveTurn = true;
    }
}
