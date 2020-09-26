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
    private int bestscore = 0;
    public Text scoreText;
    public GameObject coin;
    public Text bestscorelabel;
    private string key = "BESTSCORE";


    bool gravity = false;

    // Start is called before the first frame update
    void Start()
    { 
       rigidbody = this.GetComponent<Rigidbody>();
        bestscore = PlayerPrefs.GetInt(key, 0);
       bestscorelabel.text = "BestScore:" + bestscore.ToString();
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.Save();
    }

    void Update()
    {
        if (score > bestscore)
        {
            bestscore = score;
            PlayerPrefs.SetInt(key, bestscore);
            bestscorelabel.text = "BestScore" + bestscore.ToString();
        }

        transform.position += new Vector3(0, 0, speed * Time.deltaTime);

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
            scoreText.text = "Score:" + score;
        }
       
    }
}
