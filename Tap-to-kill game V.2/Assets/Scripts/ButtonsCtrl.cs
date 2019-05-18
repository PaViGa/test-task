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
    public void StartGame()
    {
        values.startGame = true;
        panel.SetActive(false);
        values.SetScore(0);
    }
}
