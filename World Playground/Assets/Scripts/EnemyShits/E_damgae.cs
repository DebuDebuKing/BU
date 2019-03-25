using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_damgae : MonoBehaviour {
    
    public int damagechange = 1;
    public float speed_e = 20;


    Transform player;
    Vector2 target;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
	}
	
	// Update is called once per frame
	void Update () {

       

        transform.position = Vector2.MoveTowards(transform.position, target, speed_e * Time.deltaTime);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            health_p.health -= damagechange;
        }
    }
}
