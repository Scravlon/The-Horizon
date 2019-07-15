using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Control the spawnning of the Obstacles
/// </summary>

public class obstaclesController : MonoBehaviour {

    public GameObject crashShip;
    public GameObject asteroid;
    public GameObject lSpawn;
    public GameObject mSpawn;
    public GameObject rSpawn;

    public float spawnRate;

    GameObject[] objArray;
    //Obstacles crating level y -10f
	// Use this for initialization
	void Start () {
        objArray = new GameObject[] {crashShip, asteroid};
        InvokeRepeating("randomNumber", 0, spawnRate);

    }

    // Update is called once per frame
    void Update () {
		
	}

    void randomNumber()
    {
        int rnd = Random.Range(0, 4);
        print(rnd);
        createRandomOBS(rnd);
    }
    void createRandomOBS(int type)
    {
        switch (type)
        {
            case 0:
                //middle only
                GameObject spawnOBJ = GameObject.Instantiate(objArray[Random.Range(0, 2)]);
                spawnOBJ.transform.position = mSpawn.transform.position;
                break;
            case 1:
                //left right only
                GameObject spawnL = GameObject.Instantiate(objArray[Random.Range(0, 2)]);
                GameObject spawnR = GameObject.Instantiate(spawnL);
                spawnL.transform.position = lSpawn.transform.position;
                spawnR.transform.position = rSpawn.transform.position;
                break;
            case 2:
                //left middle only
                GameObject spawnL1 = GameObject.Instantiate(objArray[Random.Range(0, 2)]);
                GameObject spawnM1 = GameObject.Instantiate(objArray[Random.Range(0, 2)]);
                spawnL1.transform.position = lSpawn.transform.position;
                spawnM1.transform.position = rSpawn.transform.position;
                break;
            case 3:
                //nothing
                break;


        }
      
    }
}
//GameObject spawnOBJ = GameObject.Instantiate(objArray[Random.Range(0, 3)]);
//spawnOBJ.transform.position = location;