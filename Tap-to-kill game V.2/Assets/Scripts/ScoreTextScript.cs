using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextScript : MonoBehaviour
{
    Text textScore;
    [SerializeField]
    Values values;
    void Start()
    {
        textScore = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
            textScore.text = values.GetScore().ToString();
        
    }
}
