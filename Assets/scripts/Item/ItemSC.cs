using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType { FOOD, WEAPON, ARMOR, MISC }
public enum Type { ITEM }
public enum ActionType { HEAL, KEY, DMG, EAT }
[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item", order = 1)]
public class ItemSC : ScriptableObject
{
    new public string name = "New Item";
    public Sprite icon;
    public Type type;
    public ItemType itemType;
    public ActionType actionType;
    public bool stackable = true;
}
