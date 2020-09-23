using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    float speed = 20.0f;
    private Rigidbody rigidbody;

    private int score = 0;
    public Text scoreText;
    public GameObject coin;

    // public GameObject gameclearCanvas;
    // bool gameclear = false;

    bool gravity = false;

    // Start is called before the first frame update
    void Start()
    {
       rigidbody = this.GetComponent<Rigidbody>();
        GameObject coin = GameObject.Find("coin");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, speed * Time.deltaTime);

     //   if (this.transform.position.z > 380)
        //{
        //    gameclear = true;
        //    gameclearCanvas.SetActive(true);


        //    if (this.transform.position.y < -150)
        //    {
        //        SceneManager.LoadScene("title");
        //    }
        //}

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
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("coin"))
        {
            score += 1;
            scoreText.text = "Score:\t" + score;
            Destroy(coin.gameObject);
        }
    }

}
