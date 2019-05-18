using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsCreator : MonoBehaviour
{
    [SerializeField]
    GameObject[] objects;
    GameObject[] objectsOnScene;
    Vector3 min, max;
    float time, borderX = 0.5f, borderY = 2;
    [SerializeField]
    Values values;
    // Start is called before the first frame update
    void Start()
    {
        objectsOnScene = new GameObject[10];
        min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        ObjectsCreate();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time > values.spawnTime && values.startGame)
        {
            ObjectTurnOn();
            time = 0;
        }
        if (!values.startGame)
        {
            foreach(GameObject obj in objectsOnScene)
            {
                obj.SetActive(false);
            }
        }
    }

    void ObjectsCreate()
    {
        for (int i = 0; i < objectsOnScene.Length; i++)
        {
           GameObject obj = Instantiate(objects[Random.Range(0, objects.Length)], new Vector2(Random.Range(min.x + borderX, max.x - borderX), Random.Range(min.y + borderY, max.y - borderY)), Quaternion.identity);
           obj.SetActive(false);
           objectsOnScene[i] = obj;

        }
    }

    void ObjectTurnOn()
    {
        int j = Random.Range(0, objectsOnScene.Length);
        while(!objectsOnScene[j].activeSelf)
        {
                objectsOnScene[j].transform.position = new Vector2(Random.Range(min.x + borderX, max.x - borderX), Random.Range(min.y + borderY, max.y - borderY));
                objectsOnScene[j].SetActive(true);
            
        }

    }
    private void OnDisable()
    {
        values.pause = false;
        values.startGame = false;
        values.SetScore(0);
    }
}
