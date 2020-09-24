﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycreater2 : MonoBehaviour
{
    float timer = 0;
    float interval;

    float speed = 20.0f;

    public GameObject stageObject2;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, speed * Time.deltaTime);

        timer += Time.deltaTime;
        interval = Random.Range(2.4f, 5.3f);
        if (timer >= interval)
        {
            transform.position = new Vector3(0, Random.Range(-15f, -9.5f), GameObject.Find("stagecreater").transform.position.z);
            Instantiate(stageObject2, transform.position, transform.rotation);
            timer = 0;
        }
    }
}
