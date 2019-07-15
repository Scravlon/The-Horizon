using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidController : MonoBehaviour {

    Rigidbody rd;
    float rnd;
    // Use this for initialization
    void Start()
    {
        rd = GetComponent<Rigidbody>();
        rnd = Random.Range(0.05f, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        rd.velocity = new Vector3(0, rd.velocity.y + rnd);
        //transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z), 0.1f);

    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Destroyer":
                Destroy(gameObject);
                break;
        }
    }
}
