using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health_p : MonoBehaviour {
    [SerializeField]
    public static int health = 100;
    public int healthshow;
    public AudioSource hitsound;
    public Text textbox;
    public GameObject deathgame;
    private void Start()
    {
       
    }

    public void Update()
    {
        healthshow = health;

       
        textbox.text = "" + health;

        if(health <= 0 )
        {
            deathgame.SetActive(true);
       hitsound.Play();
        }
    }

   
}
