using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public int health;
    public int currentHealth { get; private set; }
    public Stat mana;

    [SerializeField]
    public Stat strength;
    public Stat intellect;
    public Stat dexterity;
    public Stat endurance;
    public Stat herbalism;
    public Stat treeCutting;
    public Stat armor;

    private void Awake()
    {

        if(_instance != null && _instance != this)
        {
            Destroy(gameObject);
        } else
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
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
}
