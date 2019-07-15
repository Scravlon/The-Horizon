using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreController : MonoBehaviour {

    Text txt;
    float Score;
    public GameObject ship;
	// Use this for initialization
	void Start () {
        txt = GetComponent<Text>();
        Score = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (ship.activeSelf)
        {
            Score = Score + 0.1f;
            txt.text = Mathf.Round(Score * 100) / 100 + "km";
        }
            
    }
}
