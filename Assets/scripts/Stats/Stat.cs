using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Fields i denna class kommer att visas i inspectorn (Serializable)
[System.Serializable]
public class Stat
{
    [SerializeField]
    private int baseValue;

    public int SetValue(int newValue)
    {
        return baseValue += newValue;
    }
    public int GetValue()
    {
        return baseValue;
    }
}
