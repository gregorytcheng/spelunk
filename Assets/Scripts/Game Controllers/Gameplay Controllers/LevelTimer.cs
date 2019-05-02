using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTimer : MonoBehaviour
{
    private Slider slider;

    private GameObject player;

    private float timeBurn = 1f;

    public float time = 10f;

    // Start is called before the first frame update
    void Awake()
    {
        getReferences();
    }

    // Update is called once per frame
    void Update()
    {
        if (!player)
        {
            return;
        }

        if (time > 0)
        {
            time -= timeBurn * Time.deltaTime;
            slider.value = time;
        }
        else
        {
            GetComponent<GameplayController>().PlayerDied();
            Destroy(player);
        }
    }

    void getReferences()
    {
        player = GameObject.Find("Player");
        slider = GameObject.Find("Time Slider").GetComponent<Slider>();

        slider.minValue = 0f;
        slider.maxValue = time;
        slider.value = slider.maxValue; // starting with the maximum value
    }
}