using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IDropHandler
{
    public Image image;
    public Color selectedColor, notSelectedColor;
    public bool canSelect;

    public void Awake()
    {
        if(canSelect)
        {
            DeSelect();
        }
    }
    public void Select()
    {
        if(canSelect)
        {
            image.color = selectedColor;
        }
    }
    public void DeSelect()
    {
        if(canSelect)
        {
            image.color = notSelectedColor;
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        if(transform.childCount == 0)
        {
            GameObject dropped = eventData.pointerDrag;
            InventoryItem draggableItem = dropped.GetComponent<InventoryItem>();
            draggableItem.ParentAfterDrag = transform;
        }
    }
}
