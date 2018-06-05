using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // Use this for initialization
    //For player movement
    private Vector3 moveVector = Vector3.zero;
    //Animation controller
    private Animator anim;

    //movement speed
    public float speed;

	void Start () {

        anim = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        moveVector.z = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        moveVector.x = Input.GetAxis("Vertical2") * Time.deltaTime * speed;
        moveVector.y = 0;
        /*if(moveVector != Vector3.zero){

            anim.SetBool("Run", true);
        }
        else if(moveVector == Vector3.zero)
        {
            anim.SetBool("Run", false);
        }*/
        
        this.transform.Translate(moveVector);
	}
}
