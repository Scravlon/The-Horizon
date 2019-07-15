using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startSpawningSctipt : MonoBehaviour {

    public GameObject scriptHandler;
    public GameObject startGame;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!scriptHandler.activeSelf)
        {
            startGame.SetActive(true);
            gameObject.SetActive(false);

        }
    }
}
