using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backpack : MonoBehaviour
{
    public static bool backpackIsOpen = false;
    public GameObject backpackUI;

    private void Start()
    {
        CloseBackpack();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) || Input.GetKeyDown(KeyCode.Tab))
        {
            if (backpackIsOpen)
            {
                CloseBackpack();
            }
            else
            {
                OpenBackpack();
            }
        }
    }

    public void CloseBackpack()
    {
        backpackUI.SetActive(false);
        Time.timeScale = 1;
        backpackIsOpen = false;
    }

    void OpenBackpack()
    {
        backpackUI.SetActive(true);
        Time.timeScale = 0;
        backpackIsOpen = true;
    }
}
