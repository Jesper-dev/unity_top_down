using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemySC enemy;
    public HealthBar hpBar;
    private bool takeDamage;

    void Update()
    {
        if (takeDamage)
        {
            GameManager.Instance.currentHealth -= enemy.damage;
            hpBar.SetHealth(GameManager.Instance.currentHealth);

        }
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag.Equals("Player"))
    //    {
    //        takeDamage = true;
    //    }
    //}
}
