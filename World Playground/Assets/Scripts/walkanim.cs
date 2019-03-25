using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkanim : MonoBehaviour {
    Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKey("w") || (Input.GetKey("a") || (Input.GetKey("d") || (Input.GetKey("s")))))
            {
            anim.SetBool("walk", true);
        }
        else
        {
            anim.SetBool("walk", false);
        }


        if(Input.GetKeyDown(KeyCode.Mouse0))
            {
            anim.SetBool("attack", true);
        }
        else
        {
            anim.SetBool("attack", false);
        }
	}
}
