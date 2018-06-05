using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wormhole : MonoBehaviour {

    // Use this for initialization

    //partner of the worhole
    public GameObject partner;
    private GameObject spawnpoint;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            //teleport player to its partner spawnpoint
            spawnpoint = partner.transform.GetChild(0).gameObject;
            collider.transform.position = spawnpoint.transform.position;
        
        }
    }
}
