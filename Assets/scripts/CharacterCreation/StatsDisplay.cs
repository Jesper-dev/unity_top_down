using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsDisplay : MonoBehaviour
{
    public Text StatText;

    private void Start()
    {
        StatText = GetComponent<Text>();
    }

    private void Update()
    {
        //StatText.text = PlayerStats.;
    }
}
