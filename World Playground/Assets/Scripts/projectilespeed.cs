using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectilespeed : MonoBehaviour {
    public float speed;
    public static int damage =2 ;  

   
    void Update () {
        transform.Translate(Vector2.up * speed * Time.deltaTime);

    }

   


}
