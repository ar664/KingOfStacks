using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Grid : MonoBehaviour {

    public GameObject Plane;
    public GameObject Tile;
    //Beta Testing
    public GameObject Stack;

    public bool GridChanged = true;
    public int TileWidth = 4;
    public int TileHeight = 6;

    List<GameObject> GridTiles = new List<GameObject>();
    Vector3 TilePos = new Vector3();
    GameObject TempTile;

	// Use this for initialization
	void Start () {
        GenerateTiles();
	}
	
	// Update is called once per frame
	void Update () {
        if(GridChanged)
        {
            int TileHitDistance = 60;
            Collider[] Found;
            foreach (GameObject obj in GridTiles)
            {
                if (obj == null)
                {
                    break;
                }
                Found = Physics.OverlapBox(obj.transform.position, TileHitDistance * obj.transform.up);
                if (obj.GetComponent<Tile>().Items.Count != Found.Length)
                {
                    //Doesn't do it
                }
            }
        }
	}

    //Beta Testing Stacks
    void OnMouseDown()
    { 
        Vector3 SpawnPos = new Vector3();
        GameObject StacksOnStacks;
        int slot = (int)Random.Range(0, TileHeight * TileWidth);
        SpawnPos = GridTiles[slot].transform.position;
        SpawnPos.y = 10;
        StacksOnStacks = Instantiate(Stack, SpawnPos, Quaternion.identity) as GameObject;
    }

    void GenerateTiles()
    {
        TilePos.y = 3;
        float WidthUnit = Plane.transform.localScale.x*10 / TileWidth;
        float HeightUnit = Plane.transform.localScale.z*10 / TileHeight;
        print(WidthUnit);
        print(HeightUnit);

        for (int i = 0; i < TileWidth; i++)
        {
            for (int j = 0; j < TileHeight; j++)
            {
                TilePos.x = -12 + WidthUnit * i;
                TilePos.z = -24 + HeightUnit * j;
                TempTile = Instantiate(Tile, TilePos, Quaternion.identity) as GameObject;
                GridTiles.Add(TempTile);
                //Add Tile to Grid
            }

        }        

    }
}
