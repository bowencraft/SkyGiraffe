using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;
//using Vector2 = UnityEngine.Vector2;

public class SelPlayerMove : MonoBehaviour
{
    public GameObject MainCamera;
    public Rigidbody2D LlegBody;
    public Rigidbody2D RlegBody;
    Rigidbody2D mainBody;
    public bool grounded = false;
    public float castDist = 5f;

    public float power;
    public AudioSource audios;
    public AudioClip clips;

    public GameObject cameraPos1;
    public GameObject cameraPos2;
    public GameObject cameraPos3;
    public GameObject cameraPos4;
    public GameObject cameraPos5;

    // Start is called before the first frame update
    void Start()
    {
        mainBody = GetComponent<Rigidbody2D>();
        //audios = GetComponent<AudioSource>();
        //audios.Play();
        //Debug.Log("BGM Played.");

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            //mySource.PlayOneShot(jumpClip);
            mainBody.velocity = new Vector3(-2* power, 0.2f*power, 0);
            LlegBody.AddForce(transform.up * power, ForceMode2D.Impulse);
            RlegBody.AddForce(transform.up * power, ForceMode2D.Impulse);
            audios.PlayOneShot(clips);
            Debug.Log("Audio Played.");

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            //mySource.clip = jumpClip;
            //mySource.Play();
            RlegBody.AddForce(transform.up * power, ForceMode2D.Impulse);
            mainBody.velocity = new Vector3(power, 0, 0);
            audios.PlayOneShot(clips);
            Debug.Log("Audio Played.");

        }
        //LlegBody.GetComponent<BoxCollider2D>()

        if (true) {

            if (Input.GetKeyDown(KeyCode.W) )
            {
                if (grounded) {

                    LlegBody.AddForce(transform.up * power, ForceMode2D.Impulse);
                    RlegBody.AddForce(transform.up * power, ForceMode2D.Impulse);
                    mainBody.velocity = new Vector3(0, 0.4f * mainBody.gravityScale * power, 0);
                    Debug.Log("Ground jumped.");
                } else
                {
                    LlegBody.AddForce(transform.up * power * 0.15f, ForceMode2D.Impulse);
                    RlegBody.AddForce(transform.up * power * 0.15f, ForceMode2D.Impulse);
                    mainBody.velocity = new Vector3(0, 0.4f * mainBody.gravityScale * power, 0);

                }

                audios.PlayOneShot(clips);
                Debug.Log("Audio Played.");
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                mainBody.velocity = new Vector3(0, -power * 2, 0);

                audios.PlayOneShot(clips);
                Debug.Log("Audio Played.");
            }
        }
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    mainBody.velocity = new Vector3(-power, 0, 0);

        //}
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    mainBody.velocity = new Vector3(power, 0, 0);

        //}
    }

    private void FixedUpdate()
    {

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, castDist);
        Debug.DrawRay(transform.position, Vector2.down, Color.red);

        if (hit.collider != null && hit.collider.transform.tag == "Ground")
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }

    }

    void OnTriggerEnter2D(Collider2D collision) {
        {
            if (collision.gameObject.tag.Equals("Floor"))
            {

                //MainCamera.GetComponent<CameraMove>().PlayerObject = this.gameObject;

            }
            else if (collision.gameObject.tag.Equals("RoomTrigger"))
            {

                SceneManager.LoadScene("FailScene");

            }
            else if (collision.gameObject.tag.Equals("Finish"))
            {

                SceneManager.LoadScene("WinScene");

            }
            else if (collision.gameObject.name.Equals(cameraPos1.name)) {

                MainCamera.GetComponent<SelCamera>().SelObject = cameraPos1;
            }
            else if (collision.gameObject.name.Equals(cameraPos2.name))
            {

                MainCamera.GetComponent<SelCamera>().SelObject = cameraPos2;
            }
            else if (collision.gameObject.name.Equals(cameraPos3.name))
            {

                MainCamera.GetComponent<SelCamera>().SelObject = cameraPos3;
            }
            else if (collision.gameObject.name.Equals(cameraPos4.name))
            {

                MainCamera.GetComponent<SelCamera>().SelObject = cameraPos4;
            }
            else if (collision.gameObject.name.Equals(cameraPos5.name))
            {

                MainCamera.GetComponent<SelCamera>().SelObject = cameraPos5;
            }
            //Debug.Log("Start Collide" + collision.collider.gameObject.name);
        }
    }
}
