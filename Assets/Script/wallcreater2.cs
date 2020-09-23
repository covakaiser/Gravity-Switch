using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallcreater2 : MonoBehaviour
{
    float timer = 0;
    int interval = 3;

    float speed = 20.0f;

    public GameObject topwall;

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
            transform.position = new Vector3(0, 39, GameObject.Find("coincreater").transform.position.z);
            Instantiate(topwall, transform.position, transform.rotation);
            timer = 0;
        }
    }
}
