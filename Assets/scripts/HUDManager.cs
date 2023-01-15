using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HUDManager : MonoBehaviour
{
    public Image itemsContainer;

    public void Start()
    {
        Inventory.instance.onItemChangedCallback += UpdateInvItems;
    }

    private void UpdateInvItems()
    {
        ClearAllItemsSlots();
        FillAllItemsSlots();
    }

    private void ClearAllItemsSlots()
    {
        for(int i = 0; i < itemsContainer.transform.childCount; i++)
        {
            itemsContainer.transform.GetChild(i).GetComponent<Image>().sprite = null;
            itemsContainer.transform.GetChild(i).GetComponent<Image>().color = new Color(1, 1, 1, 0);
        }
    }

    private void FillAllItemsSlots()
    {
        if(Inventory.instance.items.Count > 0)
        {
            for(int i = 0; i < Inventory.instance.items.Count; i++)
            {
                if(Inventory.instance.items[i] != null)
                {
                    itemsContainer.transform.GetChild(i).GetComponent<Image>().sprite = Inventory.instance.items[i].icon;
                    itemsContainer.transform.GetChild(i).GetComponent<Image>().color = new Color(1, 1, 1, 1);
                } else
                {
                    itemsContainer.transform.GetChild(i).GetComponent<Image>().sprite = null;
                    itemsContainer.transform.GetChild(i).GetComponent<Image>().color = new Color(1, 1, 1, 0);
                }
            }
        }
    }
}
