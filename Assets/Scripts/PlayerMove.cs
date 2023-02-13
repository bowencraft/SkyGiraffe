using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vector3 = UnityEngine.Vector3;

public class PlayerMove : MonoBehaviour
{
    public GameObject MainCamera;
    public Rigidbody2D LlegBody;
    public Rigidbody2D RlegBody;
    Rigidbody2D mainBody;

    public float power;
    public AudioSource audios;
    public AudioClip clips;

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
            mainBody.velocity = new Vector3(-power, 0, 0);
            LlegBody.AddForce(transform.up * power, ForceMode2D.Impulse);
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

            if (Input.GetKeyDown(KeyCode.W))
            {
                LlegBody.AddForce(transform.up * power * 0.5f, ForceMode2D.Impulse);
                RlegBody.AddForce(transform.up * power * 0.5f, ForceMode2D.Impulse);
                mainBody.velocity = new Vector3(0, 0.4f * mainBody.gravityScale * power, 0);

                audios.PlayOneShot(clips);
                Debug.Log("Audio Played.");
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                mainBody.velocity = new Vector3(0, -power, 0);

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


    void OnTriggerEnter2D(Collider2D collision) {
        {
            if (collision.gameObject.tag.Equals("Floor")) {

                MainCamera.GetComponent<CameraMove>().PlayerObject = this.gameObject;

            } else if (collision.gameObject.tag.Equals("RoomTrigger"))
            {

                SceneManager.LoadScene("FailScene");

            }
            else if (collision.gameObject.tag.Equals("Finish"))
            {

                SceneManager.LoadScene("WinScene");

            }
            //Debug.Log("Start Collide" + collision.collider.gameObject.name);
        }
    }
}
