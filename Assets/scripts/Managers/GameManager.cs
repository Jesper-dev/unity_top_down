using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public int health;
    public int currentHealth { get; set; }
    public Stat mana;
    public Stat strength;
    public Stat intellect;
    public Stat dexterity;
    public Stat endurance;
    public Stat herbalism;
    public Stat treeCutting;
    public Stat armor;

    public int statPoints;

    private void Awake()
    {

        if(_instance != null && _instance != this)
        {
            Destroy(gameObject);
        } else
        {
            _instance = this;
            currentHealth = health;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) && GameManager.Instance.currentHealth > 0)
        {
            TakeDamage(20);
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            HealFullHp();
        }
    }

    public static GameManager Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = new GameManager();
            }

            return _instance;
        }
    }
    public void HealFullHp()
    {
        GameManager.Instance.currentHealth = GameManager.Instance.health;
    }

    public void TakeDamage(int dmg)
    {
        dmg -= GameManager.Instance.armor.GetValue();
        // Gör så att dmg aldrig blir mindre än 0
        dmg = Mathf.Clamp(dmg, 0, int.MaxValue);
        GameManager.Instance.currentHealth -= dmg;
    }
}
