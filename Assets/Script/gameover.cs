using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gameover : MonoBehaviour
{

    bool GAMEOVER = false;
    public GameObject gameoverCanvas;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GAMEOVER = true;
            gameoverCanvas.SetActive(true);
            Destroy(player);
        }
       
    }
}
