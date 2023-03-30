using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalTeleport : MonoBehaviour
{
    public GameObject portal;
    public GameObject player;
    public string scene;
    public float waitTime;

    public float progressTime;
    


    // Start is called before the first frame update
    void Start()
    {
        portal.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        progressTime = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        portal.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, progressTime / (waitTime * Time.deltaTime));
        if (progressTime > 0)
        {
            progressTime -= Time.deltaTime;
        }

    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.Equals(player))
        {
            //Debug.Log(collision.gameObject.name);
            if (progressTime < waitTime * Time.deltaTime)
            {
                progressTime += 2 * Time.deltaTime;
            }
            else

            {
                if (SceneManager.GetActiveScene().name.Equals("MainScene")) {

                    GmManager.levelStatus = 2;
                }

                SceneManager.LoadScene(scene);

               
            }
        }
        
    }
}
