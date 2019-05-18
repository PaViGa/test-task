using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Values", menuName = "Values")]
public class Values : ScriptableObject
{
    private int score;
    public bool startGame;
    public float spawnTime;
    public bool pause;
    public void SetScore(int i)
    { 
        score += i;
        if(i == 0)
        {
            score = 0;
        }
    }

    public int GetScore()
    {
        return score;
    }
}
