using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    float speed = 20.0f;
    private Rigidbody rigidbody;

    public GameObject gameclearCanvas;
    bool gameclear = false;
    bool gravity = false;

    // Start is called before the first frame update
    void Start()
    {
       rigidbody = this.GetComponent<Rigidbody>();
   
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, speed * Time.deltaTime);

        if (this.transform.position.z > 380)
        {
            gameclear = true;
            gameclearCanvas.SetActive(true);

            if (this.transform.position.y < -150)
            {
                SceneManager.LoadScene("title");
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            gravity = !gravity;
        }
        if (gravity)
        {
            Physics.gravity = new Vector3(0, 40, 0);
        }
        else 
       
        {
            Physics.gravity = new Vector3(0, -40, 0);
        }

    }

}
