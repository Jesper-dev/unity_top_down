using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillPointsButton : MonoBehaviour
{
    private void Update()
    {
        if(GameManager.Instance.statPoints == 0)
        {
            Destroy(this.gameObject);
        }
    }
    public void StatButtonClicked(string stat)
    {
        if(stat == "strength")
        {
            GameManager.Instance.strength.SetValue(2);
        } else if(stat == "intellect")
        {
            GameManager.Instance.intellect.SetValue(2);
        }
        else if (stat == "dexterity")
        {
            GameManager.Instance.dexterity.SetValue(2);
        }
        else if (stat == "endurance")
        {
            GameManager.Instance.endurance.SetValue(2);
        }
        GameManager.Instance.statPoints -= 1;
    }
}
