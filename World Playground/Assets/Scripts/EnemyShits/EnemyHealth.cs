using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {


    

    public static int health = 2;
    public int changehealth;
    public GameObject hitparticle;
    public int bodydamage;
    

    private void Start()
    {
        
    }
    private void Update()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        changehealth = health;

        if (collision.gameObject.tag == "bullet")
        {
             changehealth -= projectilespeed.damage;
            GameObject clone = (GameObject)Instantiate(hitparticle, transform.position, Quaternion.identity);

            Destroy(clone, 0.5f);
        }

        if(changehealth <= 0)
        {
            GameObject clone = (GameObject)Instantiate(hitparticle, transform.position, Quaternion.identity);
            
            Destroy(clone, 1f);
            Destroy(gameObject);

        }

        if (collision.gameObject.tag == "Player")
        {
            health_p.health -= bodydamage;
        }


        if (collision.gameObject.tag == "Bullet")
        {
            health -= projectilespeed.damage;
        }





    }
}

