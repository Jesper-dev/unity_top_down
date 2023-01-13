using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PickableType { SCORE, ITEM}

public class Item : MonoBehaviour
{
    [SerializeField] private PickableType type;
    [SerializeField] private int points = 0;
    [SerializeField] private ItemSC item = null;
    bool isCollected = false;
    
    void Update()
    {
        if(isCollected)
        {
            if(type.Equals(PickableType.ITEM)) {
                Inventory.instance.AddItem(item);
            }
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            isCollected = true;
        }
    }
}
