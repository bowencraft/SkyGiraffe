using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HolderDetect : MonoBehaviour
{
    public GameObject HolderCollider;
    //public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("MainBody"))
        {
            collision.gameObject.GetComponent<PlayerMove>().cameraLightning();
            Destroy(HolderCollider);
            Destroy(this);
        }

    }

    
}
