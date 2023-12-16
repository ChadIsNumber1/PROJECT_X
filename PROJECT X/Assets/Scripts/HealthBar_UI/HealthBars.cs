using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBars : MonoBehaviour
{
    [SerializeField] private Health p1HPScript;
    [SerializeField] private Health p2HPScript;
    [SerializeField] private float p1HPRatio;
    [SerializeField] private float p2HPRatio;
    [SerializeField] private Image p1HPBar;
    [SerializeField] private Image p2HPBar;

    // Start is called before the first frame update
    void Awake()
    {
        // Should grab hp bars instead of setting them in unity

        p1HPRatio = p1HPScript.GetHealthRatio();
        p2HPRatio = p2HPScript.GetHealthRatio();
    }

    // Update is called once per frame
    void Update()
    {
        if (p1HPRatio != p1HPScript.GetHealthRatio())
        {
            p1HPRatio = p1HPScript.GetHealthRatio();
            p1HPBar.fillAmount = p1HPRatio;
        }

        if (p2HPRatio != p2HPScript.GetHealthRatio())
        {
            p2HPRatio = p2HPScript.GetHealthRatio();
            p2HPBar.fillAmount = p2HPRatio;
        }

    }


}
