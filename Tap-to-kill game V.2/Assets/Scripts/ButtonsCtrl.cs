using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsCtrl : MonoBehaviour
{
    [SerializeField]
    GameObject panel;
    [SerializeField]
    Values values;
    [SerializeField]
    Button pause;
    [SerializeField]
    Text currentScore;

    public void StartGame()
    {
        values.startGame = true;
        panel.SetActive(false);
        currentScore.gameObject.SetActive(true);
        values.SetScore(0);
        pause.gameObject.SetActive(true);
    }
    public void Pause()
    {
        if (values.pause)
        {
            Time.timeScale = 1;
            values.pause = false;
        }
        else if (!values.pause)
        {
            Time.timeScale = 0;
            values.pause = true;
        }
        
    }
}
