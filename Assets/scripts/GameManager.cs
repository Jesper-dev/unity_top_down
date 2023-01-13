using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public delegate void OnScoreChangedCallback();
    public OnScoreChangedCallback onScorechangedCallback;

    #region Singleton
    public static GameManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    # endregion Singleton
    public void addScorePoints(int points)
    {
        score += points;
        onScorechangedCallback.Invoke();
    }
}
