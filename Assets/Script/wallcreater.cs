using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallcreater : MonoBehaviour
{
    float timer = 0;
    int interval = 2;

    float speed = 20.0f;

    public GameObject bottomwall;

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
            transform.position = new Vector3(0, -42, GameObject.Find("coincreater").transform.position.z);
            Instantiate(bottomwall, transform.position, transform.rotation);
            timer = 0;
        }
    }
}
