using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    private float timer;
    private int choose;
    public GameObject Scoreprefab;
    public GameObject Enemyprefab;
    private GameObject tempobj;
    
    void Start()
    {
        timer = Random.Range(2.0f, 5.0f);
    }

    
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            choose = Random.Range(0, 10);
            if (choose > 8)
            {
                tempobj= Instantiate(Scoreprefab);
                tempobj.transform.position = transform.position;
                timer = Random.Range(2.0f, 5.0f);
            }
            else
            {
                tempobj=Instantiate(Enemyprefab);
                tempobj.transform.position = transform.position;
                
                timer = Random.Range(2.0f, 5.0f);
            }
        }
        
    }
}
