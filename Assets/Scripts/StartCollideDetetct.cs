using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartCollideDetetct : MonoBehaviour
{
    public GameObject CloudObject;
    public AudioSource mySource;
    public AudioClip jumpClip;
    // Start is called before the first frame update
    void Start()
    {

        mySource.clip = jumpClip;
        mySource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            Object.Destroy(CloudObject);
        }
    }
   

    void OnTriggerEnter2D(Collider2D collision)
    {
        {
            if (collision.gameObject.tag.Equals("RoomTrigger"))
                SceneManager.LoadScene("MainScene");
        }
    }
}
