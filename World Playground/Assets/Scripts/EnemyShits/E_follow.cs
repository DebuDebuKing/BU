using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_follow : MonoBehaviour {
    public float speed;
    private Transform target;
    public GameObject bullet_E;
    float timestamp;
    public float tbs;
	// Use this for initialization
	void Start () {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
	}

    // Update is called once per frame
    private void Update()
    {
        if (Vector2.Distance(transform.position,target.position) < 10)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

            if (Time.time >= timestamp)
            {
                if (Vector2.Distance(transform.position, target.position) < 5)
                {
                    GameObject clon = (GameObject)Instantiate(bullet_E, transform.position, transform.rotation);
                    Destroy(clon, 1f);

                    timestamp = Time.time + tbs;
                }
            }

        }
    }
    
    
	
}
