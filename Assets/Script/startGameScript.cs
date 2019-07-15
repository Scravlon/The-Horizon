using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startGameScript : MonoBehaviour {


    public GameObject Viper;
    public GameObject dummyViper;
    public GameObject blackHole;
    public Camera mainCam;
    
    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        blackHole.transform.position = Vector3.Lerp(blackHole.transform.position, new Vector3(0.66f, -9.6f, -0.29f), 0.1f);

        if (mainCam.orthographicSize >= 5.7)
        {
            mainCam.orthographicSize = mainCam.orthographicSize - 0.1f;
            //mainCam.fieldOfView = mainCam.fieldOfView - 0.5f;
        } else if(mainCam.orthographicSize <= 5.7)
        {
            gameObject.SetActive(false);
        }
        Viper.transform.position = Vector3.Lerp(Viper.transform.position, dummyViper.transform.position, 0.1f);
        Viper.transform.rotation = Quaternion.Lerp(Viper.transform.rotation, dummyViper.transform.rotation, 0.1f);

       

    }
}
