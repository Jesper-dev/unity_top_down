using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootItem : MonoBehaviour
{
    [SerializeField] private PickableType type;
    bool isCollected = false;
    public ItemSC item;
    void Update()
    {
        if (isCollected)
        {
            if (type.Equals(PickableType.ITEM))
            {
                InventoryManager.instance.AddItem(item);
            }
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            isCollected = true;
        }
    }
}
