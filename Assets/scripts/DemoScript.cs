using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoScript : MonoBehaviour
{
    public InventoryManager inventoryManager;
    public ItemSC[] itemsToPickup;

    public void PickupItem(int id)
    {
        bool result =  inventoryManager.AddItem(itemsToPickup[id]);
        if(result == true)
        {
            Debug.Log("Item added");
        } else
        {
            Debug.Log("Item not added");
        }
    }

    public void GetSelectedItem()
    {
        ItemSC receivedItem = inventoryManager.GetSelectedItem(false);
        if(receivedItem != null)
        {
            Debug.Log("receivedItem " + receivedItem);
        } else
        {
            Debug.Log("Error");
        }
    }

    public void UseSelectedItem()
    {
        ItemSC receivedItem = inventoryManager.GetSelectedItem(true);
        if (receivedItem != null)
        {
            Debug.Log("UsedItem " + receivedItem);
        }
        else
        {
            Debug.Log("Error");
        }
    }
}
