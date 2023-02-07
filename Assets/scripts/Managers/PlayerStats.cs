using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Fields i denna class kommer att visas i inspectorn (Serializable)
[System.Serializable]
public class PlayerStats : MonoBehaviour
{
    public HealthBar hpBar;

    private void Start()
    {
        if(hpBar)
        {
            hpBar.SetMaxHealth(GameManager.Instance.health);
        }
    }

    private void FixedUpdate()
    {
        if(hpBar)
        {
            hpBar.SetHealth(GameManager.Instance.currentHealth);
        }
    }
}
