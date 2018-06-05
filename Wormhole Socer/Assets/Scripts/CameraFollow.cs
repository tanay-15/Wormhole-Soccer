using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    // Use this for initialization
    private GameObject player;
    private Vector3 offsetvalue;
    private Vector3 moveCam;
	void Start () {

        player = GameObject.FindGameObjectWithTag("Player");
        offsetvalue = this.transform.position  - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {


        moveCam = player.transform.position + offsetvalue;
      
        this.transform.position = moveCam;
	}
}
