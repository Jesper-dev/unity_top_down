using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyType { BOSS, COMMON, LEGENDARY }

[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemies/Enemy", order = 2)]
public class EnemySC : ScriptableObject
{
    new public string name = "Enemy";
    public EnemyType enemyType;
    public int damage;
    public int maxHealth;
    public int currentHealth;
}
