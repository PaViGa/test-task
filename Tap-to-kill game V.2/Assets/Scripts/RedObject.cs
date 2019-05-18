using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedObject : MonoBehaviour
{
    [SerializeField]
    int points;
    float borderX = 0.5f, borderY = 1;
    private Vector3 min, max;
    [SerializeField]
    private Values values;
    private void Start()
    {
        min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
    }
    private void OnMouseDown()
    {
        if (!values.pause)
        {
            values.SetScore(-points);
            gameObject.SetActive(false);
        }
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        transform.position = new Vector2(Random.Range(min.x + borderX, max.x - borderX), Random.Range(min.y + borderY, max.y - borderY));
    }
}
