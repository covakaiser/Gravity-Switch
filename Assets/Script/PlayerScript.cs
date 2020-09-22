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

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, speed * Time.deltaTime);

        if (this.transform.position.z > 170)
        {
            gameclear = true;
            gameclearCanvas.SetActive(true);

            if (this.transform.position.y < -60)
            {
                SceneManager.LoadScene("title");
            }
        }
       
    }

}
