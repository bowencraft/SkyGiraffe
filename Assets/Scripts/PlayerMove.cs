using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D LlegBody;
    public Rigidbody2D RlegBody;
    Rigidbody2D mainBody;

    public float power;
    public AudioSource mySource;
    public AudioClip jumpClip;

    // Start is called before the first frame update
    void Start()
    {
        mainBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //mySource.PlayOneShot(jumpClip);
            LlegBody.AddForce(transform.up * power, ForceMode2D.Impulse);

        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            //mySource.clip = jumpClip;
            //mySource.Play();
            RlegBody.AddForce(transform.up * power, ForceMode2D.Impulse);

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            mainBody.velocity = new Vector3(0, power, 0);

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            mainBody.velocity = new Vector3(0, -power, 0);

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            mainBody.velocity = new Vector3(-power, 0, 0);

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            mainBody.velocity = new Vector3(power, 0, 0);

        }
    }
}
