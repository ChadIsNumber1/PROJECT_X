using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timer;
    [SerializeField] private float maxTime = 120;
    [SerializeField] private float currentTime = 0;

    // Start is called before the first frame update
    void Start()
    {

        
    }


    private void Awake()
    {
        currentTime = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        // update timer

        if (currentTime > 0)
        {
            currentTime -= 1 * Time.deltaTime;
        }

        timer.text = Mathf.Round(currentTime).ToString();

        // We must make function for when timer reaches zero the player with the most health wins (Check udemy course video #91)

    }
}
