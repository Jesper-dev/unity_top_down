using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatsDisplay : MonoBehaviour
{
    public static bool displayIsOpen = false;
    public GameObject display;

    public Text strengthText;
    private string strengthStat;
    public Text intText;
    private string intStat;
    public Text dexText;
    private string dexStat;
    public Text endText;
    private string endStat;

    private void Start()
    {
        CloseDisplay();
        strengthStat = GameManager.Instance.strength.GetValue().ToString();
        intStat = GameManager.Instance.intellect.GetValue().ToString();
        dexStat = GameManager.Instance.dexterity.GetValue().ToString();
        endStat = GameManager.Instance.endurance.GetValue().ToString();
        strengthText.text = strengthStat;
        intText.text = intStat;
        dexText.text = dexStat;
        endText.text = endStat;

        //infoText.text = $"You have {GameManager.Instance.statPoints} stat points you can spend";
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (displayIsOpen)
            {
                CloseDisplay();
            }
            else
            {
                OpenDisplay();
            }
        }
        strengthStat = GameManager.Instance.strength.GetValue().ToString();
        strengthText.text = strengthStat;
        intStat = GameManager.Instance.intellect.GetValue().ToString();
        intText.text = intStat;
        dexStat = GameManager.Instance.dexterity.GetValue().ToString();
        dexText.text = dexStat;
        endStat = GameManager.Instance.endurance.GetValue().ToString();
        endText.text = endStat;
        //infoText.text = $"You have {GameManager.Instance.statPoints} stat points you can spend";
    }

    public void CloseDisplay()
    {
        display.SetActive(false);
        Time.timeScale = 1;
        displayIsOpen = false;
    }

    void OpenDisplay()
    {
        display.SetActive(true);
        displayIsOpen = true;
    }
}
