using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            Destroy(target.gameObject);
            GameObject.Find("Gameplay Controller").GetComponent<GameplayController>().PlayerDied();
        }
    }
    
}
