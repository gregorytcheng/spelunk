using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderBullet : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D target)
    {
        //if the bullet hits the player
        if (target.tag == "Player")
        {
            Destroy(target.gameObject);
            Destroy(gameObject);
            GameObject.Find("Gameplay Controller").GetComponent<GameplayController>().PlayerDied();

        }

        //if the bullet hits the ground
        if (target.tag == "Ground")
        {
           Destroy(gameObject); 

        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
