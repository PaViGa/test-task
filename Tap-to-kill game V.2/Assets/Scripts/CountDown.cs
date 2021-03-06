﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class CountDown : MonoBehaviour
{
    [SerializeField]
    Text CDtext, currentScore;
    [SerializeField]
    Values values;
    [SerializeField]
    Image img;
    float time;
    [SerializeField]
    GameObject panel;
    [SerializeField]
    Text ScoreGameOwer;
    [SerializeField]
    Button pause;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (values.startGame)
        {
            time -= Time.deltaTime;
            img.DOFillAmount(0.017f * time, 1);
            CDtext.text = Mathf.Round(time).ToString();
            if(time < 0)
            {
                values.startGame = false;
                panel.SetActive(true);
            }
        }
        else
        {
            pause.gameObject.SetActive(false);
            currentScore.gameObject.SetActive(false);
            ScoreGameOwer.text = values.GetScore().ToString();
            time = 60;
        }
    }
}
