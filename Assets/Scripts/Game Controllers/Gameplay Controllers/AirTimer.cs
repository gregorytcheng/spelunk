using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class AirTimer : MonoBehaviour
{
    private Slider slider;

    private GameObject player;

    private float airBurn = 1f;

    public float air = 10f;

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

        if (air > 0)
        {
            air -= airBurn * Time.deltaTime;
            slider.value = air;
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
        slider = GameObject.Find("Air Slider").GetComponent<Slider>();

        slider.minValue = 0f;
        slider.maxValue = air;
        slider.value = slider.maxValue; // starting with the maximum value
    }
}