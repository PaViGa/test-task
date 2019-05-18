using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GreenObject : MonoBehaviour
{
    [SerializeField]
    int points;
    [SerializeField]
    private Values values;
    private float borderX = 0.5f, borderY = 1;
    private Vector3 min, max;
    private void Start()
    {
        min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
    }
    private void OnMouseDown()
    {
        values.SetScore(points);
        gameObject.SetActive(false);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        transform.position = new Vector2(Random.Range(min.x + borderX, max.x - borderX), Random.Range(min.y + borderY, max.y - borderY));
    }

}
