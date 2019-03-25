using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{

    public GameObject projectile;
    public Transform shotpoint;
    public float offset;

    public float timebtweenshots = 1f;
    float timestamp;
   

    

    // Update is called once per frame
    void Update()
    {
        Vector2 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        float rotz = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotz + offset);



        if (Time.time >= timestamp && Input.GetKeyDown(KeyCode.Mouse0))
        {
           GameObject clone =(GameObject) Instantiate(projectile, shotpoint.position, transform.rotation);
            timestamp = Time.time + timebtweenshots;

            Destroy(clone, 0.2f);
        }
    



    }
}

