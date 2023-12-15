using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBars : MonoBehaviour
{
    public UnityEngine.UI.Image Player1_GreenHealthBar;
    public UnityEngine.UI.Image Player2_GreenHealthBar;

    public UnityEngine.UI.Image Player1_RedHealthBar;
    public UnityEngine.UI.Image Player2_RedHealthBar;

    public TextMeshProUGUI Timer;
    public float Current_Time = 120;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // update timer

        if (Current_Time > 0)
        {
            Current_Time -= 1 * Time.deltaTime;
        }

        Timer.text = Mathf.Round(Current_Time).ToString();

        // update timer


        // We must make function for when timer reaches zero the player with the most health wins (Check udemy course video #91)


        // update health of Players when damage is taken, function is incomplete (Check udemy course video #57)

        Player1_GreenHealthBar.fillAmount = Saved_Values.Player1Health;
        Player2_GreenHealthBar.fillAmount = Saved_Values.Player2Health;


    }
}
