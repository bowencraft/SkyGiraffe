using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringJump : MonoBehaviour
{
    Rigidbody2D mainBody;
    public int JumpPower = 10;
    // Start is called before the first frame update
    void Start()
    {
        mainBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        {
            if (collision.collider.gameObject.tag.Equals("Player")) {
                Debug.Log("Boom!");
                mainBody.velocity = new Vector3(0, JumpPower, 0);
            }
        }
    }
}
