using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireParticle : MonoBehaviour {

    public Transform hostTransform;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(hostTransform.position.x + 1.9f, hostTransform.position.y, hostTransform.position.z);
	}
}
