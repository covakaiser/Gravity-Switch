using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coincreater : MonoBehaviour
{
    public GameObject coin;
    float timer = 0;
    int interval = 3;

    float speed = 20.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, speed * Time.deltaTime);

        timer += Time.deltaTime;
        if (timer >= interval)
        {
            transform.position = new Vector3(0, Random.Range(-16f, 16f),GameObject.Find("coincreater").transform.position.z);
            Instantiate(coin, transform.position, transform.rotation);
            timer = 0;
        }
    }
}
