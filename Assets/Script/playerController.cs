using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    public int leftClicked;
    public int rightClicked;
    public float MoveSpeed;
    public int pos;
    public GameObject gameScript;
    public GameObject explode;
    public GameObject endGameGui;
    private float toPos;

    //Left -4.30f  Middle -2.23f  Right 0.15f
    // Use this for initialization
    void Start()
    {
        leftClicked = 0;
        rightClicked = 0;
        pos = 1;
        toPos = -2.33f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(toPos, transform.position.y, transform.position.z), 0.1f);
       
        
    }


    void OnCollisionEnter(Collision collision)
    {
        print("colided");
        switch (collision.gameObject.tag){
            case "Enemy":
                GameObject explo = GameObject.Instantiate(explode);
                explo.transform.position = new Vector3(gameObject.transform.position.x+1.9f,gameObject.transform.position.y);
                gameObject.SetActive(false);
                endGameGui.SetActive(true);
                Destroy(collision.gameObject.transform.parent.gameObject);
                break;


        }
    }

    public void getLeft()
    {
        if (pos == 1)
        {
            pos = 0;
            toPos = -4.35f;
        } else if (pos == 2)
        {
            pos = 1;
            toPos = -2.30f;
        }
    }

    public void getRight()
    {
        if(pos == 0)
        {
            pos = 1;
            toPos = -2.30f;
        } else if (pos == 1)
        {
            pos = 2;
            toPos = 0.2f;
        }
    }
  
}
