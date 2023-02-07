using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider slider;
    public Text healthText;
    public Text currentHealthText;
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        healthText.text = health.ToString();
        currentHealthText.text = health.ToString();
    }

    public void SetHealth(int health)
    {
        slider.value = health;
        currentHealthText.text = health.ToString();
    }
}
