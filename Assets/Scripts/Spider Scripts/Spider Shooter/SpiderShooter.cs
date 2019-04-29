using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderShooter : MonoBehaviour
{

    [SerializeField]
    private GameObject bullet;

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            Destroy(target.gameObject);
        }
    }

    IEnumerator Attack()
    {
        //wait between 2 and 7 seconds
        yield return new WaitForSeconds(Random.Range(2, 7));

        Instantiate(bullet, transform.position, Quaternion.identity);

        StartCoroutine(Attack());
    }


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Attack());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
