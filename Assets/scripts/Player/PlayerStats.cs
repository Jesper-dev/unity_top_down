using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Fields i denna class kommer att visas i inspectorn (Serializable)
[System.Serializable]
public class PlayerStats : MonoBehaviour
{
    private GameManager gameManager = GameManager.Instance;
    private int currentHealth;

    private void Awake()
    {
        currentHealth = gameManager.health;
    }

    void Start()
    {
        Debug.Log("current health ->" + currentHealth);    
    }
    //private void Update()
    //{
    //    if(Input.GetKeyDown(KeyCode.T))
    //    {
    //        TakeDamage(20);
    //    }
    //}

    //public void TakeDamage (int dmg)
    //{
    //    dmg -= armor.GetValue();
    //    // Gör så att dmg aldrig blir mindre än 0
    //    dmg = Mathf.Clamp(dmg, 0, int.MaxValue);
    //    currentHealth -= dmg;

    //    if(currentHealth >= 0)
    //    {
    //        Die();
    //    }
    //}

    //public virtual void Die()
    //{
    //    Debug.Log("You died");
    //}
}
