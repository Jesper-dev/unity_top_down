using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            UseIem();
        }
    }

    private void UseIem()
    {
        InventoryManager.instance.GetSelectedItem(true);
    }
}
