using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ConectToServer : MonoBehaviour
{
    [SerializeField]
    Image img;
    [SerializeField]
    GameObject panel;
    [SerializeField]
    Text LoadProcent;

    void Update()
    {
        img.DOFillAmount(1, Random.Range(1,20));
        LoadProcent.text = Mathf.Round(img.fillAmount * 100).ToString();
        if(img.fillAmount >= 0.99f)
        {
            panel.SetActive(true);
            img.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }

    }
}
